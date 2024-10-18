using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Repository.exercise.pizzashopapi.Repository;
using api_cinema_challenge.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// 1. Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowS3Bucket", policy =>
    {
        policy.WithOrigins("http://aws-muaath-day-1.s3-website.eu-north-1.amazonaws.com") // Replace with your actual S3 bucket URL
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

// 2. Use CORS middleware
app.UseCors("AllowS3Bucket");

app.UseHttpsRedirection();
app.ConfigureCinemApi();
app.UseHttpsRedirection();

app.Run();
