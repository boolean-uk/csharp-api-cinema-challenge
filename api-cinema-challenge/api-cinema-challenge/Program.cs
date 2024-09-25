using api_cinema_challenge.Controller;
using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IRepository<Customer>, CustomerRepository>();
builder.Services.AddScoped < IRepository <Movie>, MovieRepository>();
builder.Services.AddScoped < IScreening, ScreeningRepository>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<MovieService>();
builder.Services.AddScoped<ScreeningService>();
builder.Services.AddDbContext<CinemaContext> (opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DockerConnectionString"));
    opt.LogTo(message => Debug.WriteLine(message));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCustomerEndpoint();
app.ConfigureMovieEndpoint();
app.ConfigureScreeningEndpoint();
app.Run();
