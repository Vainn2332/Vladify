using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Extensions;
using Vladify.BusinessLogic.Options;
using Vladify.Middlewares;

namespace Vladify.Extensions;

public static class ApiExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddOpenApiDocumentation(configuration)
            .AddJwtBasedAuthentication(configuration)
            .AddAuthorization()
            .AddHttpClient()
            .AddCors(configuration)
            .ConfigureOptions(configuration)
            .AddBusinessLogicLayer(configuration);

        return services;
    }

    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
    }

    public static IEndpointRouteBuilder MapScalar(this IEndpointRouteBuilder app, IConfiguration configuration)
    {
        app.MapScalarApiReference(options =>
        {
            options.WithTheme(ScalarTheme.BluePlanet);

            options.AddPreferredSecuritySchemes("Auth0")
                .AddAuthorizationCodeFlow("Auth0", flow =>
                {
                    var auth0Options = configuration.GetSection(Auth0Options.SectionName).Get<Auth0Options>()
                        ?? throw new NotFoundException($"Configuration section{Auth0Options.SectionName} not found!");

                    flow.ClientId = auth0Options.PublicClient.ClientId;
                    flow.Pkce = Pkce.Sha256;
                    flow.AddQueryParameter("audience", auth0Options.PublicClient.Audience);
                });
        });

        return app;
    }

    public static IServiceCollection AddOpenApiDocumentation(this IServiceCollection services, IConfiguration configuration)
    {
        var auth0Options = configuration.GetSection(Auth0Options.SectionName).Get<Auth0Options>()
            ?? throw new NotFoundException($"Configuration section{Auth0Options.SectionName} not found!");

        services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                var domain = auth0Options.Domain;

                var securityScheme = new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri($"https://{domain}/authorize"),
                            TokenUrl = new Uri($"https://{domain}/oauth/token"),
                            Scopes = new Dictionary<string, string>
                            {
                                { "openid", "OpenID" },
                                { "profile", "Profile" },
                                { "email", "Email" }
                            }
                        }
                    }
                };

                document.Components ??= new OpenApiComponents();
                document.Components.SecuritySchemes.Add("Auth0", securityScheme);

                return Task.CompletedTask;
            });
        });

        return services;
    }

    public static IServiceCollection AddJwtBasedAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var auth0Options = configuration.GetSection(Auth0Options.SectionName).Get<Auth0Options>()
            ?? throw new NotFoundException($"Configuration section{Auth0Options.SectionName} not found!");

        var domain = auth0Options.Domain;
        var audience = auth0Options.PublicClient.Audience;

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = $"https://{domain}";

                options.Audience = audience;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true
                };
            });

        return services;
    }

    public static IServiceCollection ConfigureOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<Auth0Options>(configuration.GetSection(Auth0Options.SectionName));
        services.Configure<MinioOptions>(configuration.GetSection(MinioOptions.SectionName));

        services.Configure<ApiKeysOptions>("Auth0", options =>
            options.Value = configuration["ApiKeys:Auth0SyncInDb"] ?? throw new ArgumentException("Failed to get Auth0ApiKey from configuration!"));

        services.Configure<RabbitMqOptions>(configuration.GetSection(RabbitMqOptions.SectionName));

        return services;
    }

    public static IServiceCollection AddCors(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("DefaultPolicy", policy =>
            {
                policy.WithOrigins(configuration["FrontendPath"])
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        return services;
    }
}
