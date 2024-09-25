using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screening");

            screeningGroup.MapPost("createscreening", CreateScreening);
            screeningGroup.MapGet("screenings", GetScreenings);
        }

        public static async Task<IResult> CreateScreening(ScreeningService service, ScreeningPayload payload, int id)
        {
            var screening = await service.Create(payload, id);

            return TypedResults.Ok(new ReturnValue("success", screening));
        }

        public static async Task<IResult> GetScreenings(ScreeningService service, int movieId)
        {
            var screening = await service.GetAll(movieId);

            return TypedResults.Ok(new ReturnValue("success", screening));
        }
    }
}
