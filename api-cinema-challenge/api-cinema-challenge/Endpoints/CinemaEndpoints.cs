using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");
            cinemaGroup.MapGet("/movies", GetMovies);
            cinemaGroup.MapGet("/movies/{id}", GetMovie);
            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            return Results.Ok(await repository.GeneratePayload(movies));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovie(IRepository repository, int id)
        {
            var movie = await repository.GetMovie(id);
            if(movie == null)
            {
                return TypedResults.NotFound(await repository.GenerateErrorPayload(movie, $"Movie with id {id} was not found"));
            }

            var resp = await repository.GeneratePayload(movie);

            return Results.Ok(resp);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MovieDTO? movie)
        {

            var movieCreated = await repository.CreateMovie(movie);
            return Results.Created($"/cinema/movies/{movieCreated.Id}", await repository.GeneratePayload(movieCreated));
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, MovieDTO? movie)
        {
            var updatedMovie = await repository.UpdateMovie(id, movie);
            return Results.Created($"/cinema/movies/{updatedMovie.Id}", await repository.GeneratePayload(updatedMovie));

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var deletedMovie = await repository.DeleteMovie(id);
            if (deletedMovie == null)
            {
                return Results.BadRequest(await repository.GenerateErrorPayload(deletedMovie, $"Movie with id {id} was not found"));
            }

            return Results.Ok(await repository.GeneratePayload(deletedMovie));

        }
    }
}
