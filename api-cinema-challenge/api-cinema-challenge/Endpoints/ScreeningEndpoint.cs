using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public record ScreeningPostPayload(int screenNumber, int capacity, DateTime startsAt);

    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("movies");

            screeningGroup.MapGet("/{movieId}/screenings", GetScreenings);
            screeningGroup.MapPost("/{movieId}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IScreeningRepository repository, int movieId)
        {
            List<Screening?> screens = await repository.GetScreenings(movieId);
            if (screens == null || screens.Count == 0)
                return Results.BadRequest("No screenings for that movie");

            return TypedResults.Ok(ScreeningResponseDTO.FromRepository(screens));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateScreening(IScreeningRepository repository, ScreeningPostPayload payload, int movieId)
        {
            var screens = await repository.CreateScreening(payload.screenNumber, payload.capacity, payload.startsAt, movieId);
            if (screens == null)
                return Results.BadRequest("Could not make that screening");

            ScreeningResponseDTO screening = ScreeningResponseDTO.FromARepository(screens);
            return TypedResults.Created($"/screenings{screening.Status} {screening.Datas}", screening);
        }
    }
}
