using Vladify.BusinessLogic.Extensions;
using Vladify.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddOpenApiDocumentation(builder.Configuration)
    .AddJwtBasedAuthentication(builder.Configuration)
    .AddAuthorization()
    .AddHttpClient()
    .ConfigureOptions(builder.Configuration)
    .AddBusinessLogicLayer(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapScalar(builder.Configuration);
}

app.UseGlobalExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }