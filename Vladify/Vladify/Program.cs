using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
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
        var domain = builder.Configuration["Auth0:Domain"];

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
//default scheme for authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
{
    //configuring JWT authentication scheme

    //Auth0 tenant
    options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}";
    //Auth0 API ID
    options.Audience = builder.Configuration["Auth0:AuthServiceIdentifier"];

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
    };
});

builder.Services.AddAuthorization();

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
