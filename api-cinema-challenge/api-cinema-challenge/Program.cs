using System.Diagnostics;
using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<CinemaContext>();

builder.Services.AddScoped<IRepository<Screening>, Repository<Screening>>();
builder.Services.AddScoped<IRepository<Customer>, Repository<Customer>>();
builder.Services.AddScoped<IRepository<Movie>, Repository<Movie>>();
builder.Services.AddScoped<IRepository<Ticket>, Repository<Ticket>>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<CinemaContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString"));
    options.LogTo(message => Debug.WriteLine(message));

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureScreeningEndpoints();
app.ConfigureCustomerEndpoints();
app.ConfigureMovieEndpoints();

app.SeedAsync();
app.UseHttpsRedirection();
app.Run();
