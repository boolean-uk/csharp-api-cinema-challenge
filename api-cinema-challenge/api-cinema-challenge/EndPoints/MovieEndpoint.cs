using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieEndpoint
    {
        public static void configureMovieEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("movie");
            group.MapGet("/", GetAllMovies);
            group.MapPost("/", CreateMovie);
            group.MapPut("/{id:int}", UpdateMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IMovieRepository repository)
        {
            var movies = await repository.GetMovies();
            return TypedResults.Ok(movies);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IMovieRepository repository, CreateMovieDto model)
        {
            Movie movieCreated = await repository.CreateMovie(model);
            return TypedResults.Ok(movieCreated);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, int id, CreateMovieDto model)
        {
            Movie movieUpdated = await repository.UpdateMovie(id, model);
            if(movieUpdated == null)
            {
                return TypedResults.NotFound("Id does not exist");
            }
            return TypedResults.Created("", movieUpdated);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            Movie movieDeleted = await repository.DeleteMovie(id);
            if(movieDeleted == null)
            {
                return TypedResults.NotFound("Does not exist");
            }
            return TypedResults.Ok(movieDeleted);
        }
    }
}
