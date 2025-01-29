using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
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

builder.Services.AddScoped<IRepository<Customer, int>, Repository<Customer, int>>();
builder.Services.AddScoped<IRepository<Movie, int>, Repository<Movie, int>>();
builder.Services.AddScoped<IRepository<Screen, int>, Repository<Screen, int>>();
builder.Services.AddScoped<IRepository<Screening, int>, Repository<Screening, int>>();
builder.Services.AddScoped<IRepository<Seat, int>, Repository<Seat, int>>();
builder.Services.AddScoped<IRepository<Ticket, int>, Repository<Ticket, int>>();
builder.Services.AddAutoMapper(typeof(Program));

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
app.ConfigureSeatsEndpoints();
app.ConfigureScreensEndpoints();
app.ConfigureTicketsEndpoints();

app.Run();
