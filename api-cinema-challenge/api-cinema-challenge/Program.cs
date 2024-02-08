using api_cinema_challenge.Controllers;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddDbContext<CinemaContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString"));
    opt.LogTo(message => Debug.WriteLine(message));

});
builder.Services.AddScoped<IRepository<Customer>, Repository<Customer>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCustomerEndpoint();
app.Run();

public partial class Program { } // needed for testing - please ignore