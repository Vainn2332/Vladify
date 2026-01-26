using Scalar.AspNetCore;
using Vladify.BusinessLogic.Extensions;
using Vladify.Extensions;
using Vladify.Filters;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
});

builder.Services.AddOpenApi();

builder.Services.AddBusinessLogicLayer(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapScalarApiReference(options =>
    {
        options.WithTheme(ScalarTheme.BluePlanet);
    });
}

app.UseGlobalExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
