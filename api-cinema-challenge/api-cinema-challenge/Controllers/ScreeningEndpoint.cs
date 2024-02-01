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
        }

        public static async Task<IResult> CreateScreening(IScreeningRepository screeningRepository, IMovieRepository movieRepository, ScreeningPayload payload, int id)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");

            return TypedResults.Created("", new ScreeningResponseDTO(await screeningRepository.CreateScreening(id, payload.screenNumber, payload.capacity, payload.startsAt)));
        }
        public static async Task<IResult> GetScreening(IScreeningRepository screeningRepository, IMovieRepository movieRepository, int id)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");
            var screenings = await screeningRepository.GetScreenings(id);
            List<ScreeningResponseDTO> results = new List<ScreeningResponseDTO>();
            foreach (Screening screening in screenings)
            {
                results.Add(new ScreeningResponseDTO(screening));
            }
            return TypedResults.Ok(results);
        }
    }
}
