using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
         public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");
            cinema.MapGet("movies/{id}/screenings", GetAllScreeningsByMovieID);
            cinema.MapPost("movies/{id}/screenings", CreateScreening);
        }

        public static async Task<IResult> GetAllScreeningsByMovieID(int id, ICinemaRepository repository)
        {
            var screenings = await repository.GetAllScreeningsByMovieID(id);
            if (screenings.Count == 0)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new ScreeningListResponseDTO("success", screenings));
        }

        public static async Task<IResult> CreateScreening(CreateScreeningPayload payload, ICinemaRepository repository)
        {
            if (payload.MovieId <= 0)
            {
                return TypedResults.BadRequest("MovieId must be greater than 0");
            }
            if (payload.ScreenNumber <= 0)
            {
                return TypedResults.BadRequest("ScreenNumber must be greater than 0");
            }
            if (payload.Capacity <= 0)
            {
                return TypedResults.BadRequest("Capacity must be greater than 0");
            }
            if (payload.StartTime == default)
            {
                return TypedResults.BadRequest("StartTime is required");
            }
            Screening? screening = await repository.CreateScreening(payload.MovieId, payload.ScreenNumber, payload.Capacity, payload.StartTime, payload);

            return TypedResults.Ok(new ScreeningResponseDTO("success", screening));
        }
    }
}