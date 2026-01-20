using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Extensions;

namespace Vladify.BusinessLogic.Extensions;

public static class BLExtensions
{
    public static IServiceCollection AddSqlServerDb(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ApplicationDbContext");
        if (connectionString is null)
        {
            throw new InvalidOperationException("Conection string 'ApplicationDbContext' is not found!");
        }

        services.AddDbInDataAccess(connectionString);

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSongRepository();

        services.AddScoped<ISongService, SongService>();

        return services;
    }
}
