using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Payload;
using api_cinema_challenge.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();

builder.Services.AddScoped<IRepository<Customer, CustomerPayload>, CustomerRepository>();
builder.Services.AddScoped<IRepository<Ticket, TicketPayload>, TicketRepository>();
builder.Services.AddScoped<IRepository<Screening, ScreeningPayload>, ScreeningRepository>();
builder.Services.AddScoped<IRepository<Movie, MoviePayload>, MovieRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.ConfigureCustomerEndpoint();
app.ConfigureScreeningEndpoint();
app.ConfigureMovieEndpoint();
app.ConfigureTicketEndpoint();
app.Run(); 