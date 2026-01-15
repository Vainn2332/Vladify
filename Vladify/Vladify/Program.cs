using Microsoft.EntityFrameworkCore;
using Vladify.BusinessLogic;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddOpenApi();

string? connectionString = builder.Configuration.GetConnectionString("ApplicationDbContext");

if (connectionString is not null)
{
    builder.Services.AddDbInBusinessLogic(connectionString);
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
