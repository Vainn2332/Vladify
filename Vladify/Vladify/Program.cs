using Scalar.AspNetCore;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Extensions;
using Vladify.Extensions;
using Vladify.Options;

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
                var auth0Options = builder.Configuration.GetSection(Auth0Options.SectionName).Get<Auth0Options>()
                    ?? throw new NotFoundException($"Configuration section{Auth0Options.SectionName} not found!");

                flow.ClientId = auth0Options.ClientId;
                flow.Pkce = Pkce.Sha256;
                flow.AddQueryParameter("audience", auth0Options.Audience);
            });
    });
}

app.UseGlobalExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
