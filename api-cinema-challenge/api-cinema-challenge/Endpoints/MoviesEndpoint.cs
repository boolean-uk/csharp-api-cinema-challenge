
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace workshop.wwwapi.Endpoints
{
    public static class MoviesEndpoint
    {
        public static void ConfigureMoviesEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");
            movies.MapPost("/", CreateAMovie);
            movies.MapGet("/", GetAllMovies);
            movies.MapPut("/{id}", UpdateAMovie);
            movies.MapDelete("/{id}", DeleteAMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllMovies( IRepository<Movies> repo)
        {
            throw new NotImplementedException();
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteAMovie( IRepository<Movies> repo)
        {
            throw new NotImplementedException();
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAMovie(HttpContext context, IRepository<Movies> repo)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateAMovie(HttpContext context, IRepository<Movies> repo)
        {
            throw new NotImplementedException();
        }
    }
}
