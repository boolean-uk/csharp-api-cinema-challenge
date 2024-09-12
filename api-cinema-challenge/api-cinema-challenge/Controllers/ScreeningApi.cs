using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("/screenings")]
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            var screenings = app.MapGroup("screenings");
            screenings.MapPost("/", CreateScreening);
            screenings.MapGet("/", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateScreening(IRepository repository, int screenNumber, int capacity, DateTime startsAt)
        {
            try
            {TestInput(screenNumber); TestInput(capacity); 
                Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
                payload.data = repository.CreateScreening(screenNumber, capacity, startsAt);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest();
            }
            catch (Exception ex) { 
                return TypedResults.BadRequest();
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetScreenings(IRepository repository)
        {
            try
            {
                Payload<List<ScreeningDTO>> payload = new Payload<List<ScreeningDTO>>();
                payload.data = repository.GetScreenings();
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest();

            }
            catch (Exception ex) { 
                return TypedResults.BadRequest();

            }
        }

        private static void TestInput(int input)
        {
            int test = input;
        }
    }
}
