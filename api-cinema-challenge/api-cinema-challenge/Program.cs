using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using workshop.wwwapi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<Customers>, Repository<Customers>>();
builder.Services.AddScoped<IRepository<Movies>, Repository<Movies>>();
builder.Services.AddScoped<IRepository<Screenings>, Repository<Screenings>>();
builder.Services.AddScoped<IRepository<Tickets>, Repository<Tickets>>();
builder.Services.AddDbContext<CinemaContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCustomersEndpoint();
app.ConfigureMoviesEndpoint();
app.ConfigureScreeningsEndpoint();
app.ConfigureTicketsEndpoint();
app.Run();
