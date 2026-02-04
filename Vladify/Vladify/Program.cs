using Scalar.AspNetCore;
using Vladify.BusinessLogic.Extensions;
using Vladify.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApiDocumentation(builder.Configuration);

builder.Services.AddJwtBasedAuthentication(builder.Configuration);

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
