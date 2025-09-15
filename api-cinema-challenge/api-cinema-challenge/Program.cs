using api_cinema_challenge;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>(opt =>
    {
        opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString"));
    });

builder.Services.AddScoped<IMovieRepository,MovieRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();
builder.Services.AddScoped<ITicketRepository,TicketRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureMovieApi();
app.ConfigureTicketApi();
app.ConfigureScreeningApi();
app.ConfigureCustomerApi();
app.ApplyProjectMigrations();
app.Run();

public partial class Program { } // needed for testing - please ignore