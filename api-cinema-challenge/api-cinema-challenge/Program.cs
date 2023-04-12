using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "TITLE_OF_PROJECT_API",
        Description = "DESCRIPTION_OF_API",
        Contact = new OpenApiContact
        {
            Name = "YOUR_NAME",
            Url = new Uri("https://example.com/contact")
        }
    });
});

// @TODO Uncomment next 2 lines and add your context class here
//builder.Services.AddDbContext<DB_CONTEXT_NAME_HERE>(
//    o => o.UseNpgsql(builder.Configuration.GetConnectionString("CinemaDBConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
