using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOS;
using api_cinema_challenge.Repositories.customer;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screenings = app.MapGroup("/movies/{id}/screenings");

            screenings.MapPost("", CreateScreening);
            screenings.MapGet("", GetAllScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private async static Task<IResult> CreateScreening(IScreeningRepository repository, int id, ScreeningPayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }



            var newScreening = await repository.Add(id, payload.ScreenNumber, payload.Capacity, payload.StartsAt);
            return newScreening == null ? TypedResults.NotFound("Movie not found") : TypedResults.Created($"/movies/{id}/screenings/{newScreening.Id}", new ScreeningDTO(newScreening));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private async static Task<IResult> GetAllScreenings(IScreeningRepository repository, int id)
        {
            List<Screening> allScreenings = await repository.GetAll(id);
            List<ScreeningDTO> resultScreening = new List<ScreeningDTO>();
            if (allScreenings.Count == 0) { return TypedResults.NotFound("No screenings where found"); }

            foreach (var screening in allScreenings)
            {
                resultScreening.Add(new ScreeningDTO(screening));
            }

            return TypedResults.Ok(resultScreening);
        }
    }
}
