using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;

namespace api_cinema_challenge.Controllers
{
    
    public static class MovieEndpoint {

    public static void ConfigureMovieEndpoint(this WebApplication app)
    {
    var movieGroup = app.MapGroup("movies");
    var customerGroup = app.MapGroup("customers");

      //  movieGroup.MapGet("/", GetAllMovies);
    //movieGroup.MapPost("/", AddMovie);
    //movieGroup.MapPut("/{id}", EditMovie);
    //movieGroup.MapDelete("/{id}", DeleteMovie);
    //customerGroup.MapGet("/", GetAllCustomers);
    // customerGroup.MapPost("/", AddCustomer);
    // customerGroup.MapPut("/{id}", EditCustomer);
    // customerGroup.MapDelete("/{id}", DeleteCustomer);
    //movieGroup.MapPost("/{id}/screenings", AddScreening);
    //movieGroup.MapGet("/{id}/screenings", GetScreenings);

    }





















}    
}