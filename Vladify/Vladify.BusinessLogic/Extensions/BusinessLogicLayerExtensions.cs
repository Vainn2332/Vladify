using AutoMapper;
using FluentValidation;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vladify.BusinessLogic.MapperProfiles;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Options;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.BusinessLogic.Services;
using Vladify.BusinessLogic.Validators;
using Vladify.DataAccess.Extensions;

namespace Vladify.BusinessLogic.Extensions;

public static class BusinessLogicLayerExtensions
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddSqlServerDb(configuration)
            .AddServices()
            .AddValidators()
            .AddRabbitMQ(configuration)
            .AddMapping();

        return services;
    }

    private static IServiceCollection AddSqlServerDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbInDataAccess(configuration);

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddRepositories()
            .AddScoped<ISongService, SongService>()
            .AddScoped<IUserService, UserService>()
            .AddScoped<IAuth0Service, Auth0Service>()
            .AddScoped<IPlaylistService, PlaylistService>();

        return services;
    }

    private static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services
            .AddScoped<IValidator<SongRequestModel>, SongValidator>()
            .AddScoped<IValidator<PlaylistRequestModel>, PlaylistValidator>();

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

    public static IServiceCollection AddRabbitMQ(this IServiceCollection services, IConfiguration configuration)
    {
        var rabbitOptions = configuration.GetSection(RabbitMqOptions.SectionName).Get<RabbitMqOptions>()
            ?? throw new ArgumentException($"Failed to bind section {RabbitMqOptions.SectionName}!");

        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(rabbitOptions.ServerHost, h =>
                {
                    h.Username(rabbitOptions.Username);
                    h.Password(rabbitOptions.Password);
                });

                cfg.ConfigureEndpoints(context);
            });
        });

        return services;
    }
}
