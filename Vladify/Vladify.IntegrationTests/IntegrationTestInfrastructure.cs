using Amazon.S3;
using Amazon.S3.Util;
using MassTransit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Respawn;
using System.Data.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Testcontainers.Minio;
using Testcontainers.MsSql;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess;
using Vladify.DataAccess.Dtos;
using Vladify.DataAccess.Interfaces;

namespace Vladify.IntegrationTests;

public class IntegrationTestInfrastructure : IAsyncLifetime
{
    private readonly MsSqlContainer _testDbContainer = new MsSqlBuilder().Build();
    private readonly MinioContainer _minioContainer = new MinioBuilder().Build();
    private Respawner _respawner = null!;
    private DbConnection _connection = null!;

    public WebApplicationFactory<Program> Factory { get; private set; } = null!;

    public HttpClient Client { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        await Task.WhenAll(_testDbContainer.StartAsync(), _minioContainer.StartAsync());
        Factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
        {
            builder.ConfigureAppConfiguration((context, configBuilder) =>
            {
                configBuilder.AddInMemoryCollection(new Dictionary<string, string?>
                {
                    ["RabbitMqOptions:ServerHost"] = "localhost",
                    ["RabbitMqOptions:Username"] = "test",
                    ["RabbitMqOptions:Password"] = "test",
                    ["ApiKeys:Auth0SyncInDb"] = "testApiKey",
                    ["Auth0:M2MClient:ClientId"] = "test",
                    ["Auth0:M2MClient:ClientSecret"] = "test",
                    ["Auth0:M2MClient:Audience"] = "test",
                    ["Auth0:PublicClient:ClientId"] = "test",
                    ["Auth0:PublicClient:ClientSecret"] = "test",
                    ["Auth0:PublicClient:Audience"] = "test",
                    ["Auth0:Domain"] = "test",
                    ["Auth0:TokenUrl"] = "test",
                    ["S3Options__ServiceUrl"] = _minioContainer.GetConnectionString(),
                    ["S3Options__AccessKey"] = BootstrapConstants.MinioUser,
                    ["S3Options__SecretKey"] = BootstrapConstants.MinioPassword,
                    ["S3Options__BucketName"] = BootstrapConstants.TestBucket
                });
            });

            builder.ConfigureServices(services =>
            {
                ConfigureTestServices(services);

                services.PostConfigure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidAudience = TestConstants.Audience,
                    ValidateIssuer = true,
                    ValidIssuer = TestConstants.Issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TestConstants.TestSecretKey))
                });
            });
        });

        Client = Factory.CreateClient();

        using var scope = Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await dbContext.Database.MigrateAsync();

        await EnsureBucketExistenceAsync();

        _connection = new SqlConnection(_testDbContainer.GetConnectionString());
        await _connection.OpenAsync();
        _respawner = await Respawner.CreateAsync(_connection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
            SchemasToInclude = ["dbo"],
            TablesToIgnore = ["__EFMigrationsHistory"],
        });
    }

    public async Task ResetDataAsync()
    {
        await _respawner.ResetAsync(_connection);

        using var scope = Factory.Services.CreateScope();
        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();
        var list = await s3.ListObjectsV2Async(new() { BucketName = BootstrapConstants.TestBucket });
        foreach (var obj in list.S3Objects)
            await s3.DeleteObjectAsync(BootstrapConstants.TestBucket, obj.Key);
    }

    public static string GenerateTestJWT(string userEmail = TestConstants.TestJwtEmailClaimValue)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TestConstants.TestSecretKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new List<Claim>()
        {
            new Claim(ClaimConstants.CustomEmailClaimName, userEmail)
        };

        var token = new JwtSecurityToken(
            issuer: TestConstants.Issuer,
            audience: TestConstants.Audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: credentials
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public async Task DisposeAsync()
    {
        Client.Dispose();
        await Factory.DisposeAsync();
        await _testDbContainer.DisposeAsync();
        await _minioContainer.DisposeAsync();
    }

    public async Task<T> SeedDataAsync<T>(T entity) where T : class
    {
        using var scope = Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();

        return entity;
    }

    public void ConfigureTestServices(IServiceCollection services)
    {
        services
            .RemoveAll<DbContextOptions<ApplicationDbContext>>()
            .RemoveAll<IAuth0Service>()
            .RemoveAll<IPublishEndpoint>()
            .RemoveAll<IModerationIntegrationClient>();

        var authServiceMock = new Mock<IAuth0Service>();
        authServiceMock.Setup(m => m.DeleteUserFromAuth0Async(It.IsAny<string>())).Returns(Task.CompletedTask);

        var publishEndpointMock = new Mock<IPublishEndpoint>();
        publishEndpointMock
            .Setup(m => m.Publish(It.IsAny<object>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        var moderationMock = new Mock<IModerationIntegrationClient>();
        var fakeModerationTaskDto = new ModerationTaskDto() { Id = Guid.NewGuid() };
        moderationMock.Setup(m => m.CreateTaskAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(fakeModerationTaskDto);

        services.AddScoped(serviceProvider => authServiceMock.Object);
        services.AddScoped(serviceProvider => publishEndpointMock.Object);
        services.AddScoped(serviceProvider => moderationMock.Object);

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(_testDbContainer.GetConnectionString()));
    }

    private async Task EnsureBucketExistenceAsync()
    {
        using var scope = Factory.Services.CreateScope();
        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();

        if (!await AmazonS3Util.DoesS3BucketExistV2Async(s3, BootstrapConstants.TestBucket))
            await s3.PutBucketAsync(BootstrapConstants.TestBucket);
    }

    public async Task<bool> CheckPresenceInBucket(IAmazonS3 s3, string url, CancellationToken cancellationToken)
    {
        var data = await s3.GetObjectMetadataAsync(BootstrapConstants.TestBucket, url, cancellationToken);

        return data is not null;
    }
}
