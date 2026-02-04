using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Vladify.Middlewares;

namespace Vladify.Extensions;

public static class ApiExtensions
{
    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
    }

    public static IServiceCollection AddOpenApiDocumentation(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                var domain = configuration["Auth0:Domain"];

                var securityScheme = new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            // Where Scalar redirects to input password
                            AuthorizationUrl = new Uri($"https://{domain}/authorize"),
                            // Where Scalar exchanges input on JWT
                            TokenUrl = new Uri($"https://{domain}/oauth/token"),
                            //What info we'd like to get
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
        var domain = configuration["Auth0:Domain"];
        var audience = configuration["Auth0:AuthServiceIdentifier"];

        //default scheme for authentication
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                //Who established JWT
                options.Authority = $"https://{domain}";

                //Receiver of this JWT
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
}
