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

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowS3Bucket", policy =>
    {
        policy.WithOrigins("http://http://aws-dennisosmani-day-2.s3-website.eu-north-1.amazonaws.com/") // Replace with your actual S3 bucket URL
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

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
