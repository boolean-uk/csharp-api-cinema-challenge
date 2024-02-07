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

        movieGroup.MapGet("/", GetAllMovies);
        movieGroup.MapPost("/", AddMovie);    
        movieGroup.MapPut("/{id}", EditMovie);
        movieGroup.MapDelete("/{id}", DeleteMovie);

    }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository repository, int id)
        {
            throw new NotImplementedException();
            //TODO: Return IEnumerable<DTMovie>
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddMovie(IRepository repository, PostScreening model)//TODO: Add PostMovie model
        {
            throw new NotImplementedException();
            //TODO: Return DTMovie
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> EditMovie(IRepository repository, int id, PostScreening model)//TODO: Add PostMovie model
        {
            throw new NotImplementedException();
            //TODO: Return DTMovie
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            throw new NotImplementedException();
            //TODO: Return DTMovie
        }

















    }
}