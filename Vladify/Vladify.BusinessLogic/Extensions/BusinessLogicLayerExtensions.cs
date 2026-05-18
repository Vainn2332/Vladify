using Amazon.Runtime;
using Amazon.S3;
using AutoMapper;
using FluentValidation;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vladify.BusinessLogic.Exceptions;
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
            .AddMiniO(configuration)
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
            .AddScoped<IPlaylistService, PlaylistService>()
            .AddScoped<ISearchService, SearchService>()
            .AddScoped<IStorageService, StorageService>();

        return services;
    }

    private static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services
            .AddScoped<IValidator<SongAddDto>, SongValidator>()
            .AddScoped<IValidator<PlaylistAddDto>, PlaylistValidator>();

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

    private static IServiceCollection AddMiniO(this IServiceCollection services, IConfiguration configuration)
    {
        var minioConfig = configuration.GetSection(MinioOptions.SectionName).Get<MinioOptions>()
            ?? throw new NotFoundException("Failed to get minioOptions");
        services.AddSingleton<IAmazonS3>(sp =>
        {
            var awsCreds = new BasicAWSCredentials(minioConfig.AccessKey, minioConfig.SecretKey);
            var awsConfig = new AmazonS3Config
            {
                ServiceURL = minioConfig.ServiceUrl,
                ForcePathStyle = true
            };

            return new AmazonS3Client(awsCreds, awsConfig);
        });

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
