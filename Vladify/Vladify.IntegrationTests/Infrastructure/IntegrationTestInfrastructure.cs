using MassTransit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Moq;
using System.Text;
using Testcontainers.Minio;
using Testcontainers.MsSql;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess;
using Vladify.DataAccess.Dtos;
using Vladify.DataAccess.Interfaces;
using Vladify.IntegrationTests.Constants;

namespace Vladify.IntegrationTests.Infrastructure;

public class IntegrationTestInfrastructure : IAsyncLifetime
{
    private readonly MsSqlContainer _testDbContainer = new MsSqlBuilder()
        .WithName("sqlContainer")
        .Build();
    private readonly MinioContainer _minioContainer = new MinioBuilder()
        .WithImage(BootstrapConstants.MinioImageContainerVersion)
        .WithName("minioContainer")
        .WithUsername(BootstrapConstants.MinioUser)
        .WithPassword(BootstrapConstants.MinioPassword)
        .Build();


    public DataResetter DataResetter { get; private set; } = null!;
    public DataSeeder DataSeeder { get; private set; } = null!;
    public WebApplicationFactory<Program> Factory { get; private set; } = null!;
    public HttpClient Client { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        await Task.WhenAll(_testDbContainer.StartAsync(), _minioContainer.StartAsync());

        var minioUrl = _minioContainer.GetConnectionString();
        if (!minioUrl.StartsWith("http")) minioUrl = "http://" + minioUrl;

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
                    ["S3Options:ServiceUrl"] = minioUrl,
                    ["S3Options:AccessKey"] = BootstrapConstants.MinioUser,
                    ["S3Options:SecretKey"] = BootstrapConstants.MinioPassword,
                    ["S3Options:BucketName"] = BootstrapConstants.TestBucket
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
        DataSeeder = new DataSeeder(Factory.Services);
        DataResetter = await DataResetter.CreateAsync(_testDbContainer.GetConnectionString(), Factory.Services);
    }

    private void ConfigureTestServices(IServiceCollection services)
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

    public async Task DisposeAsync()
    {
        Client?.Dispose();
        await Factory.DisposeAsync();
        await DataResetter.DisposeAsync();
        await _testDbContainer.DisposeAsync();
        await _minioContainer.DisposeAsync();
    }
}
