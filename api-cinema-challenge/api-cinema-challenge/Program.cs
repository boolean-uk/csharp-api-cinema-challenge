using api_cinema_challenge.Data;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Controllers;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureMovieEndpoint();
app.ConfigureCustomerEndpoint();
app.ConfigureScreeningEndpoint();
app.Run();
