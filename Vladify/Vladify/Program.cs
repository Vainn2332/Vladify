using Microsoft.EntityFrameworkCore;
using Vladify.BusinessLogic.Extensions;
using Vladify.BusinessLogic.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddOpenApi();

string? connectionString = builder.Configuration.GetConnectionString("ApplicationDbContext");

if (connectionString is not null)
{
    builder.Services.AddDbInBusinessLogic(connectionString);
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataSeeder = scope.ServiceProvider.GetRequiredService<IDataSeeder>();
    dataSeeder?.SeedData();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
