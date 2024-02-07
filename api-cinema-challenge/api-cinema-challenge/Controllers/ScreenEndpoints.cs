using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOS;
using api_cinema_challenge.Repositories.customer;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreenEndpoints
    {
        public static void ConfigureScreenEndpoints(this WebApplication app)
        {
            var screen = app.MapGroup("/screens");

            screen.MapPost("", AddScreen);
            screen.MapGet("", GetAllScreens);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private async static Task<IResult> AddScreen(IScreenRepository repository, ScreenPayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }

            var screen = await repository.Add(payload.Capacity);
            return screen == null ? TypedResults.BadRequest("Screen was not added") : TypedResults.Ok(screen);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private async static Task<IResult> GetAllScreens(IScreenRepository repository)
        {
            var allScreens = await repository.GetAll();
            var resultScreens = new List<ScreenDTO>();
            if (allScreens.Count == 0) { return TypedResults.NotFound("No screens where found"); }

            foreach (var screen in allScreens)
            {
                resultScreens.Add(new ScreenDTO(screen));
            }

            return TypedResults.Ok(resultScreens);
        }
    }
}
