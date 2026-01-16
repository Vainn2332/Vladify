using Microsoft.Extensions.DependencyInjection;
using Vladify.BusinessLogic.Interfaces;
using Vladify.DataAccess.Extensions;

namespace Vladify.BusinessLogic.Extensions;

public static class BLExtensions
{
    public static IServiceCollection AddDbInBusinessLogic(this IServiceCollection services, string connectionString)
    {
        services.AddDbInDataAccess(connectionString);

        services.AddScoped<IDataSeeder, DataSeeder>();

        return services;
    }
}
