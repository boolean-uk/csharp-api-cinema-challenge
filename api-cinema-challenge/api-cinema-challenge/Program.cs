using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IRepo<Customer>, Repo<Customer>>();
builder.Services.AddScoped<IRepo<Movie>, Repo<Movie>>();
builder.Services.AddScoped<IRepo<Screening>, Repo<Screening>>();
builder.Services.AddScoped<IRepo<Ticket>, Repo<Ticket>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureEndpoint();
app.Run();
