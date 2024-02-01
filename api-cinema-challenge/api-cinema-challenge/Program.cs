using api_cinema_challenge.Controllers;
using api_cinema_challenge.Data;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Repositories.customer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepo>();
builder.Services.AddScoped<IMovieRepository, MovieRepo>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCustomerEndpoints();
app.ConfigureMovieEndpoints();
app.ConfigureScreeningEndpoints();
app.Run();
