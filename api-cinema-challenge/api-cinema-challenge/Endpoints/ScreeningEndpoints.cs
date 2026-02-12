using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.SpecificRepositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {

        public static void ConfigureScreeningApi(this WebApplication app)
        {

            var screenings = app.MapGroup("/movies/{movieId}/screenings");
            screenings.MapPost("/", CreateScreening);
            screenings.MapGet("/", GetAllScreeningsForMovie);
        }

        // Create a Screening for a Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(int movieId, Screening screening, IScreeningRepository screeningRepository)
        {
            screening.MovieId = movieId;
            await screeningRepository.AddAsync(screening);
            return TypedResults.Created($"/movies/{movieId}/screenings/{screening.Id}", new { status = "success", data = screening });
        }

        // Get all Screenings for a Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreeningsForMovie(int movieId, IScreeningRepository screeningRepository)
        {
            var screenings = await screeningRepository.GetScreeningsByMovieAsync(movieId);
            return TypedResults.Ok(new { status = "success", data = screenings });
        }
    }
}
