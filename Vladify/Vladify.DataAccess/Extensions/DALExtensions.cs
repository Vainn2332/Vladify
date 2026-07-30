using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vladify.DataAccess.Clients;
using Vladify.DataAccess.Interfaces;
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
}
