using api_cinema_challenge.Data;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repository;
using api_cinema_challenge.DataContext;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICinemaRepository, CinemaRepository>();
builder.Services.AddDbContext<CinemaContext>();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Cinema_Booking_Api",
        Description = "Cinema_Booking_Api",
        Contact = new OpenApiContact
        {
            Name = "Ntina_B",
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.ConfigureMoviesApi();
app.ConfigureTicketsApi();
app.ConfigureCustomersApi();
app.ConfigureScreeningsApi();

app.Seed();

app.Run(); 