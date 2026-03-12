using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Respawn;
using System.Data.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Testcontainers.MsSql;
using Vladify.DataAccess;

namespace Vladify.IntegrationTests;

public class IntegrationTestInfrastructure : IAsyncLifetime
{
    private readonly MsSqlContainer _testDbContainer = new MsSqlBuilder().Build();
    private Respawner _respawner = null!;
    private DbConnection _connection = null!;

    public WebApplicationFactory<Program> Factory { get; private set; } = null!;

    public HttpClient Client { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        await _testDbContainer.StartAsync();
        Factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                services.RemoveAll<DbContextOptions<ApplicationDbContext>>();

                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(_testDbContainer.GetConnectionString()));

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
        dbContext.Database.Migrate();

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
    }

    public static string GenerateTestJWT()
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TestConstants.TestSecretKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: TestConstants.Issuer,
            audience: TestConstants.Audience,
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
    }

    public async Task<T> SeedDataAsync<T>(T entity) where T : class
    {
        using var scope = Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();

        return entity;
    }
}
