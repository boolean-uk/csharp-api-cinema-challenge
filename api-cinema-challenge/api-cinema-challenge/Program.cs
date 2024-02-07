using api_cinema_challenge.Controllers;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.MovieModels;
using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();

// TODO: Handle repositories
builder.Services.AddScoped<IRepository<Customer>, Repository<Customer>>();
builder.Services.AddScoped<IRepository<Movie>, Repository<Movie>>();
builder.Services.AddScoped<IRepository<Screening>, Repository<Screening>>();


var app = builder.Build();

using (var dbContext = new CinemaContext(new DbContextOptions<CinemaContext>()))
{
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// TODO: Handle endpoints
app.ConfigureCustomerEndpoint();
app.ConfigureMovieEndpoint();
app.ConfigureScreeningEndpoint();

app.UseHttpsRedirection();
app.Run();
