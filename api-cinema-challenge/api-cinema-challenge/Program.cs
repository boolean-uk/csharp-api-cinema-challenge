using api_cinema_challenge.Reposities.MovieRepo;
using api_cinema_challenge.Reposities.ScreeningRepo;
using api_cinema_challenge.Reposities.TicketRepo;
using api_cinema_challenge.Reposities.UserRepo;
using api_cinema_challenge.Data;
using api_cinema_challenge.Views;
using api_cinema_challenge.Repositories.SeatRepo;
using api_cinema_challenge.Repositories.BookingRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ISeatRepository, SeatRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();

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
