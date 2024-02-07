using api_cinema_challenge.Data;
using api_cinema_challenge.Endoints;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CinemaContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddScoped<IMovieRepository , MovieRepository>();
builder.Services.AddScoped<IScreeningRepository , ScreeningRepository>();
builder.Services.AddScoped<ICustomerRepository , CustomerRepository>();
builder.Services.AddScoped<ITicketRepository , TicketRepository>();
builder.Services.AddScoped<IBookingRepository , BookingRepository>();
builder.Services.AddScoped<IScreenRepository , ScreenRepository>();
builder.Services.AddScoped<ISeatRepository , SeatRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureCustomerEndpoint();
app.ConfigureMovieEndpoint();
app.ConfigureScreeningEndpoint();
app.ConfigureBookingEndpoint();
app.ConfigureSeatEndpoint();
app.ConfigureTicketEndpoint();
app.ConfigureScreenEndpoint();

app.ApplyProjectMigrations();
app.Run();
