using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ICinemaRepo, CinemaRepo>();

//TODO: change the capitalized strings in the options to match your api and contact details
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "CinemaApi",
        Description = "CinemaApi",
        Contact = new OpenApiContact
        {
            Name = "Thanasis Andritsios",
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

app.ConfigureCustomerAPI();
app.ConfigureMovieAPI();
app.ConfigureScreeningAPI();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
