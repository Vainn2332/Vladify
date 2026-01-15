using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Vladify.DataAccess;

public static class MyExtensions
{
    public static IServiceCollection AddDbInDataAccess(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));

        return services;
    }
}
