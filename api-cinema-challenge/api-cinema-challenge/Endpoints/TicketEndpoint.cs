using api_cinema_challange.Models;
using api_cinema_challange.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace api_cinema_challange.Endpoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapGet("/tickets", GetAllTickets);
        }

        private static async Task<IResult> GetAllTickets(ITicketRepository ticketRepository)
        {
            return TypedResults.Ok(await ticketRepository.GetAllTickets());
        }

    }
}
