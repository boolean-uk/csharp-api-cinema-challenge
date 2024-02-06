using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Data;
using api_cinema_challenge.Infrastructure;
using api_cinema_challenge.Presentation.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();


// Add repositories
builder.Services.AddScoped<IRepository<Ticket>, GenericRepository<Ticket>>();
builder.Services.AddScoped<IRepository<Movie>, GenericRepository<Movie>>();
builder.Services.AddScoped<IRepository<Screening>, GenericRepository<Screening>>();
builder.Services.AddScoped<IRepository<Customer>, GenericRepository<Customer>>();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureCustomerEndpoint();

app.UseHttpsRedirection();
app.Run();
