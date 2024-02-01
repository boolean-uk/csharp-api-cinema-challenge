


using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Endpoints {
    public static class TicketEndpoints {
        
        public static void ConfigureTicketsEndpoints(this WebApplication app) {
            var movies = app.MapGroup("/tickets");

            movies.MapGet("/", GetTickets);
            movies.MapGet("/{Id}", GetTicket);
            movies.MapPut("/{Id}", UpdateTicket);
            movies.MapPost("/{customerId}", CreateTicket);
            movies.MapDelete("/{Id}", DeleteTicket);
        }

        private static async Task DeleteTicket(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task CreateTicket(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task UpdateTicket(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task GetTicket(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task GetTickets(ITicketRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}