using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using Vladify.BusinessLogic.Extensions;
using Vladify.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi(options =>
{
    options.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        var domain = builder.Configuration["Auth0:Domain"]; // Например: "vladify.auth0.com"

        var securityScheme = new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.OAuth2,
            Flows = new OpenApiOAuthFlows
            {
                AuthorizationCode = new OpenApiOAuthFlow
                {
                    // Куда Scalar перенаправит тебя для ввода пароля
                    AuthorizationUrl = new Uri($"https://{domain}/authorize"),
                    // Где Scalar обменяет "код" на реальный JWT токен
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

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = "https://dev-e5yk0xsv7lcoyajl.us.auth0.com";
    options.Audience = builder.Configuration["Auth0:AuthServiceIdentifier"];
});

builder.Services.AddBusinessLogicLayer(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapScalarApiReference(options =>
    {
        options.WithTheme(ScalarTheme.BluePlanet);

        options.AddPreferredSecuritySchemes("Auth0")
            .AddAuthorizationCodeFlow("Auth0", flow =>
            {
                flow.ClientId = builder.Configuration["Auth0:ClientID"];
                flow.Pkce = Pkce.Sha256;
                flow.AddQueryParameter("audience", builder.Configuration["Auth0:AuthServiceIdentifier"]);
            });
    });
}

app.UseGlobalExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
