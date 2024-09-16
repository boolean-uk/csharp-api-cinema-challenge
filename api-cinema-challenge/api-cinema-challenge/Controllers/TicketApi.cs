using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("/tickets")]
    public static class TicketApi
    {
        private static string payloadStatusSuccess = "Success";
        private static string payloadStatusFailure = "Failure";
        public static void ConfigureTicketApi(this WebApplication app)
        {
            var tickets = app.MapGroup("tickets");
            tickets.MapPost("/", CreateTicket);
            tickets.MapGet("/", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTickets(IRepository repository)
        {
            try
            {
                Payload<List<TicketDTO>> payload = new Payload<List<TicketDTO>>();
                payload.data = repository.GetTickets();
                payload = checkPayloadList(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest(payload);
            }
            catch (Exception ex) {
                return TypedResults.BadRequest(ex);
            }

        }

        //id of movie and not ticket, ticket is composite key of movie id and numSeats
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateTicket(IRepository repository, int id)
        {
            try
            {
                TestInput(id);
                Payload<TicketDTO> payload = new Payload<TicketDTO>();
                payload.data = repository.BookTicket(id);
                payload = checkPayload(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload); //movie id not found
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }

        private static Payload<TicketDTO> checkPayload(Payload<TicketDTO> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            } else
            {
                payload.status = payloadStatusFailure; 
                return payload;
            }
        }

        private static Payload<List<TicketDTO>> checkPayloadList(Payload<List<TicketDTO>> payload)
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
