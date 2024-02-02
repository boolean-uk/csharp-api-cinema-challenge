using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("/movies");
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
            movieGroup.MapGet("/{id}/screenings", GetScreening);
            movieGroup.MapGet("/screenings", GetAllScreenings);
        }

        public static async Task<IResult> CreateScreening(IMovieRepository movieRepository, ScreeningPayload payload, int id)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");

            return TypedResults.Created("", new ScreeningOutput("success", await movieRepository.CreateScreening(id, payload.screenNumber, payload.capacity, payload.startsAt)));
        }
        public static async Task<IResult> GetScreening(IMovieRepository movieRepository, int id)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");
            var screenings = await movieRepository.GetScreenings(id);
            return TypedResults.Ok(new ScreeningListOutput("success", screenings));
        }

        public static async Task<IResult> GetAllScreenings(IMovieRepository movieRepository)
        {
            return TypedResults.Ok(new ScreeningListOutput("success", await movieRepository.GetAllScreenings()));
        }
    }
}
