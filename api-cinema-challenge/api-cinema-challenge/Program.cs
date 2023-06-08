using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();
builder.Services.AddScoped<IScreenRepository, ScreenRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//TODO: change the capitalized strings in the options to match your api and contact details
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Cinema Booking API Challenge",
        Description = "This API manages the movies in a cinema.",
        Contact = new OpenApiContact
        {
            Name = "Max de Ruiter",
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
app.ConfigureScreenAPI();
app.ConfigureTicketAPI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
