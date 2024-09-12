
using api_cinema_challenge.Models;
using api_cinema_challenge.Payloads;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie");

            movieGroup.MapPost("/CreateMovie", CreateMovie);
            movieGroup.MapGet("/GetAllMovie", GetMovies);
            movieGroup.MapPut("/UpdateMovie/{id}", UpdateMovieById);
            movieGroup.MapDelete("DeleteMovie/{id}", DeleteMovieById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteMovieById(IRepository repository, int movieId)
        {
            try
            {
                return TypedResults.Ok(await repository.DeleteMovie(movieId));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateMovieById(IRepository repository, int movieId, MoviePayload payload)
        {
            try
            {
                var result = await repository.UpdateMovie(movieId, payload);
                return TypedResults.Created($"http://localhost:7195/customers/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(IRepository repository)
        {
            return TypedResults.Ok(await repository.GetMovies());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovie(IRepository repository, MoviePayload payload)
        {
            try
            {
                var result = await repository.CreateMovie(payload);
                return TypedResults.Created($"http://localhost:7195/customers/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
