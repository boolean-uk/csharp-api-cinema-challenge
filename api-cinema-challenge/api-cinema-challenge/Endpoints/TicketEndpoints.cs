


using api_cinema_challenge.Data.DTO;
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Endpoints {
    public static class TicketEndpoints {
        
        public static void ConfigureTicketsEndpoints(this WebApplication app) {
            var movies = app.MapGroup("/tickets");

            movies.MapGet("/", GetTickets);
            movies.MapGet("/{Id}", GetTicket);
            movies.MapPut("/{Id}", UpdateTicket);
            movies.MapPost("/{customerId}/{screeningId}", CreateTicket);
            movies.MapDelete("/{Id}", DeleteTicket);
        }

        private static async Task DeleteTicket(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> CreateTicket(ITicketRepository repository, int customerId, int screeningId, CreateTicketPayload payload)
        {
            await repository.CreateTicket(customerId, screeningId, payload.seats);
            return Results.Ok("Created");
        }

        private static async Task UpdateTicket(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> GetTicket(ITicketRepository repository, int Id)
        {
            if(Id <= 0)
                return Results.BadRequest("Not a valid ID");
            var ticket = await repository.GetTicket(Id);
            if(ticket == null)
                return Results.NotFound("No ticket with ID: " + Id + " Found");
            return TypedResults.Ok(new TicketDTO(ticket));
        }

        private static async Task GetTickets(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}