using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Vladify.BusinessLogic.MapperProfiles;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.BusinessLogic.Validators;

namespace Vladify.BusinessLogic.Extensions;

public static class BLLExtensions
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
    {
        services
            .AddServices()
            .AddValidators()
            .AddMapping();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddScoped<ISongService, SongService>()
            .AddScoped<IUserService, UserService>();

        return services;
    }

    private static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<SongRequestModel>, SongValidator>();

        return services;
    }

    private static IServiceCollection AddMapping(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { }, typeof(SongProfile).Assembly);

        var sp = services.BuildServiceProvider();
        var mapper = sp.GetRequiredService<IMapper>();

        mapper.ConfigurationProvider.AssertConfigurationIsValid();

        return services;
    }
}
