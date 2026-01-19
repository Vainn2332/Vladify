using Microsoft.Extensions.DependencyInjection;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Extensions;

namespace Vladify.BusinessLogic.Extensions;

public static class BLExtensions
{
    public static IServiceCollection AddDbInBusinessLogic(this IServiceCollection services, string connectionString)
    {
        services.AddDbInDataAccess(connectionString);

        return services;
    }

    public static IServiceCollection AddSongService(this IServiceCollection services)
    {
        services.AddSongRepository();

        services.AddScoped<ISongService, SongService>();

        return services;
    }
}
