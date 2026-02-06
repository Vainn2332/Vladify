using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Vladify.BusinessLogic.Exceptions;
using Vladify.Middlewares;
using Vladify.Options;

namespace Vladify.Extensions;

public static class ApiExtensions
{
    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
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
        var audience = auth0Options.Audience;

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

        return services;
    }
}
