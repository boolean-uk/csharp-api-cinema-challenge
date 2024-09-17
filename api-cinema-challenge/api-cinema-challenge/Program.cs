using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Repositories;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Endpoints
app.ConfigureCustomerEndpoints();
app.ConfigureMovieEndpoints();
app.ConfigureScreeningEndpoints();
app.ConfigureTicketEndpoints();

app.Run();
