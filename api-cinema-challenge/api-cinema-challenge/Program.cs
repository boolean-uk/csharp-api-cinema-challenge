using api_cinema_challenge.Data;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.configureMovieEndpoint();
app.configureCustomerEndpoint();
app.configureScreeningEndpoint();
app.UseHttpsRedirection();
app.Run();
