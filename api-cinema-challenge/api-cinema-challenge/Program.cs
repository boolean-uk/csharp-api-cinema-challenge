using api_cinema_challange;
using api_cinema_challange.Endpoints;
using api_cinema_challange.Repository;
using api_cinema_challenge.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();

builder.Services.AddScoped<IMovieRepository,MovieRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();
builder.Services.AddScoped<ITicketRepository,TicketRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureMovieApi();
app.ConfigureTicketApi();
app.ConfigureScreeningApi();
app.ConfigureCustomerApi();
app.Run();
