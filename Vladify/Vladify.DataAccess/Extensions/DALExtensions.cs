using Amazon.S3;
using Amazon.S3.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Vladify.DataAccess.Clients;
using Vladify.DataAccess.Interfaces;
using Vladify.DataAccess.Options;
using Vladify.DataAccess.Repositories;
using Vladify.GrpcContracts;

namespace Vladify.DataAccess.Extensions;

public static class DalExtensions
{
    public static IServiceCollection AddDbInDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ApplicationDbContext")
            ?? throw new InvalidOperationException("Conection string 'ApplicationDbContext' is not found!");

        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));

        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services
            .AddScoped(typeof(IRepository<>), typeof(Repository<>))
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IPlaylistRepository, PlaylistRepository>()
            .AddScoped<ISongRepository, SongRepository>()
            .AddScoped<IModerationIntegrationClient, ModerationIntegrationClient>();

        return services;
    }

    public static IServiceCollection AddS3Storage(this IServiceCollection services, IConfiguration configuration)
    {
        var s3Options = configuration.GetSection("S3Options").Get<S3Options>()
            ?? throw new InvalidOperationException("S3Options section is not configured!");

        services.AddSingleton(_ =>
        {
            var config = new AmazonS3Config
            {
                ServiceURL = s3Options.ServiceUrl,
                ForcePathStyle = true
            };

            return new AmazonS3Client(s3Options.AccessKey, s3Options.SecretKey, config);
        });

        return services;
    }

    public static IServiceCollection AddGrpcClients(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddGrpcClient<ModerationGrpc.ModerationGrpcClient>(options =>
        {
            var url = configuration["GrpcClients:ModerationServiceUrl"]
                ?? throw new InvalidOperationException("ModerationServiceUrl is not configured!");

            options.Address = new Uri(url);
        });

        return services;
    }

    public static async Task MigrateDatabaseAsync(this IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await context.Database.MigrateAsync();
    }

    public static async Task EnsureBucketExistenceAsync(this IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();
        var opts = scope.ServiceProvider.GetRequiredService<IOptions<S3Options>>().Value;

        if (!await AmazonS3Util.DoesS3BucketExistV2Async(s3, opts.BucketName))
            await s3.PutBucketAsync(opts.BucketName);
    }

}
