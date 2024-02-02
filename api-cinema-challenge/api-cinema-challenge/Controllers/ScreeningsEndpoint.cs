using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningsEndpoint
    {
        public static void ConfigureScreeningsEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screenings");

            screeningGroup.MapPost("/{screeningsId}", CreateScreening);
            screeningGroup.MapGet("/", GetAllScreenings);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IScreeningsRepository screeningsRepository, NewScreening newData, int movieId)
        {
            //Check that newData has all values
            if(newData.Capacity == 0 || newData.StartsAt == null || newData.ScreenNr == 0 || movieId == 0)
            {
                return TypedResults.BadRequest("You must enter data for all fields!");
            }
            //Create the new screening
            var screening = new GetScreeningDTO(await screeningsRepository.CreateScreening(newData.ScreenNr, newData.Capacity, newData.StartsAt, movieId));
            return TypedResults.Created($"/{screening.ScreenNr}", screening);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreenings(IScreeningsRepository screeningsRepository, int movieId)
        {
            var screening = GetScreeningDTO.FromRepository(await screeningsRepository.GetScreenings(movieId));
            return TypedResults.Ok(screening);
        }
    }
}
