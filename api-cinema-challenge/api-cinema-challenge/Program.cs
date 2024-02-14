using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.ExtensionRepository;
using api_cinema_challenge.Repository.GenericRepository;
using System.Numerics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IRepository<Movie>, MovieRepo>();
builder.Services.AddScoped<IRepository<Ticket>, TicketRepo>();
builder.Services.AddScoped<IRepository<Screening>, ScreeningRepo>();
builder.Services.AddScoped<IRepository<Customer>, CustomerRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureMovieEndpoint();
app.ConfigureTicketEndpoint();
app.ConfigureScreeningEndpoint();
app.ConfigureCustomerEndpoint();
app.Run();
