using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("/screenings")]
    public static class ScreeningApi
    {
        private static string payloadStatusSuccess = "Success";
        private static string payloadStatusFailure = "Failure";
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
                payload = checkPayload(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest(payload);
            }
            catch (Exception ex) { 
                return TypedResults.BadRequest(ex);
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
                payload = checkPayloadList(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest(payload);

            }
            catch (Exception ex) { 
                return TypedResults.BadRequest(ex);

            }
        }

        private static Payload<ScreeningDTO> checkPayload(Payload<ScreeningDTO> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            }
            else
            {
                payload.status = payloadStatusFailure;
                return payload;
            }
        }

        private static Payload<List<ScreeningDTO>> checkPayloadList(Payload<List<ScreeningDTO>> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            }
            else
            {
                payload.status = payloadStatusFailure;
                return payload;
            }
        }

        private static void TestInput(int input)
        {
            int test = input;
        }
    }
}
