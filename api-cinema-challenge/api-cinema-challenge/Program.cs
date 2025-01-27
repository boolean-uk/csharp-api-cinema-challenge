using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
builder.Services.AddDbContext<DataContext>(options =>
{
    var connectionString = configuration.GetConnectionString("DefaultConnectionString");
    options.UseNpgsql(connectionString);

    options.ConfigureWarnings(warnings =>
        warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
});


builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.ConfigureCustomersEndpoints();
app.ConfigureMoviesEndpoints();
app.ConfigureScreeningsEndpoints();

app.Run();
