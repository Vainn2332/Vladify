using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Extensions;

public static class DALExtensions
{
    public static IServiceCollection AddDbInDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ApplicationDbContext")
            ?? throw new InvalidOperationException("Conection string 'ApplicationDbContext' is not found!");

        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));

        return services;
    }

    public static IServiceCollection AddSongRepository(this IServiceCollection services)
    {
        services.AddScoped<ISongRepository, SongRepository>();

        return services;
    }
}
