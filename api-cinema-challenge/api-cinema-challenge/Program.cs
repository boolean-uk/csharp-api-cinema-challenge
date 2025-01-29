using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<ICinemaRepository<Customer>, CinemaRepository<Customer>>();
builder.Services.AddScoped<ICinemaRepository<Movie>, CinemaRepository<Movie>>();
builder.Services.AddScoped<ICinemaRepository<Screen>, CinemaRepository<Screen>>();
builder.Services.AddScoped<ICinemaRepository<Ticket>, CinemaRepository<Ticket>>();
builder.Services.AddScoped<ICinemaRepository<ScreenMovie>, CinemaRepository<ScreenMovie>>();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCinemaEndpoint();
app.Run();
