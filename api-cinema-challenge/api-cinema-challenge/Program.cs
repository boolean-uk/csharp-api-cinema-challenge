using api_cinema_challenge.Data;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Seeder;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
        options.JsonSerializerOptions.MaxDepth = 128;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault;
    });// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped(typeof(IDataRepository<>), typeof(DataRepository<>));

//TODO: change the capitalized strings in the options to match your api and contact details
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "This is not a cinema",
        Description = "Not a cinema",
        Contact = new OpenApiContact
        {
            Name = "avadakedavrO",
        }
    });
});


var app = builder.Build();

// to seed the database every time the app starts
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<CinemaContext>();
var seeder = new Seeder(context);

if (app.Environment.IsDevelopment())
{
    seeder.SeedAll().Wait(); // to seed the database in development mode
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureGenericAPI<Customer>();
app.ConfigureGenericAPI<Movie>();
app.ConfigureGenericAPI<Screening>();
app.ConfigureGenericAPI<Ticket>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
