using api_cinema_challenge.Data;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Endpoints;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.Configure<MvcOptions>(options =>
{
    options.ModelMetadataDetailsProviders.Add(
        new SystemTextJsonValidationMetadataProvider());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureMovieEndpoints();
app.ConfigureCustomerEndpoints();
app.ConfigureCinemaEndpoints();
app.Run();

public partial class Program { }