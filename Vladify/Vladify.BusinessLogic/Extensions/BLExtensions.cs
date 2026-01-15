using Microsoft.Extensions.DependencyInjection;
using Vladify.DataAccess.Extensions;

namespace Vladify.BusinessLogic.Extensions;

public static class BLExtensions
{
    public static IServiceCollection AddDbInBusinessLogic(this IServiceCollection services, string connectionString)
    {
        services.AddDbInDataAccess(connectionString);

        return services;
    }
}
