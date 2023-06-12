using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Context;
using api_cinema_challenge.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

////TODO: change the capitalized strings in the options to match your api and contact details
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Cinema Challenge",
        Description = "This API dealing with cinema needs",
        Contact = new OpenApiContact
        {
            Name = "Valentina Galiamova",
        }
    });
});
builder.Services.AddScoped<ICinemaRepository, CinemaRepository>();
builder.Services.AddDbContext<CinemaContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureCustomersApi();

app.ConfigureMoviesApi();

app.ConfigureScreeningsApi();

app.ConfigureTicketsApi();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Seed();

app.Run();
