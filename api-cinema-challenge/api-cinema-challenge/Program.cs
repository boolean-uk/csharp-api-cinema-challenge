using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddDbContext<CinemaContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//TODO: change the capitalized strings in the options to match your api and contact details
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Cinema Booking Api",
        Description = "A complete Cinema Booking API in C# using ASP.NET and Entity Framework",
        Contact = new OpenApiContact
        {
            Name = "Konstantina Stafyla",
        }
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureTestAPI();

app.ConfigureCustomerApi();
app.ConfigureMovieApi();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
