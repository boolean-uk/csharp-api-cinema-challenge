using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Mapper;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddValidatorsFromAssemblyContaining<CreateScreeningValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureCustomerEndpoints();
app.ConfigureMovieEndpoints();

app.Run();
