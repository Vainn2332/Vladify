using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Extensions;

public static class DALExtensions
{
    public static IServiceCollection AddDbInDataAccess(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));

        services.AddScoped<IDbInitializer, DbInitializer>();

        return services;
    }
}
