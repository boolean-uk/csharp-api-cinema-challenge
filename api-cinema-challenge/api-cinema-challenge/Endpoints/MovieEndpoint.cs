using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {

            var customerGroup = app.MapGroup("movie");

            customerGroup.MapGet("/movies", GetMovies);
            customerGroup.MapPost("/createmovie", CreateMovie);
            customerGroup.MapPost("/updatemovie/{id}", UpdateMovie);
            customerGroup.MapDelete("/deletemovie/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(MovieService service)
        {
            var movies = await service.GetAll();
            if (movies == null)
            {
                return TypedResults.StatusCode(StatusCodes.Status404NotFound);
            }
            return TypedResults.Ok(new ReturnValue("success", movies));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateMovie(MovieService service, MoviePayload payload)
        {

            var movie = await service.Create(payload);

            return TypedResults.Ok(new ReturnValue("success", movie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(MovieService service, MoviePayload payload, int id)
        {

            var movie = await service.Update(payload, id);

            return TypedResults.Ok(new ReturnValue("success", movie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(MovieService service, int id)
        {
            var movie = await service.Delete(id);
            return TypedResults.Ok(new ReturnValue("success", movie));
        }
    }
}
