using Microsoft.Extensions.DependencyInjection;
using Vladify.DataAccess;

namespace Vladify.BusinessLogic;

public static class MyExtensions
{
    public static IServiceCollection AddDbInBusinessLogic(this IServiceCollection services, string connectionString)
    {
        services.AddDbInDataAccess(connectionString);
        return services;
    }
}
