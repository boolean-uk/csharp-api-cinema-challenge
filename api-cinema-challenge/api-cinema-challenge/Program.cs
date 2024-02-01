using api_cinema_challenge.Controllers.MovieRepo;
using api_cinema_challenge.Controllers.ScreeningRepo;
using api_cinema_challenge.Controllers.UserRepo;
using api_cinema_challenge.Data;
using api_cinema_challenge.Views;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureUserApi();
app.ConfigureMovieApi();
app.Run();
