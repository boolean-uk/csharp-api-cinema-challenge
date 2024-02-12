

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("tickets");

            customers.MapPost("/{customerID}/screenings/{screenID}", CreateTicket);
            customers.MapGet("/{customerID}/screenings/{screenID}", ReadAllTickets);
            //customers.MapPut("/{id}", ReadATicket);
            //customers.MapPut("/{id}", UpdateTicket);
            //customers.MapDelete("/{id}", DeleteTicket);
        }

        private static Task CreateTicket(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadAllTickets(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadATicket(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task UpdateTicket(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task DeleteTicket(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
