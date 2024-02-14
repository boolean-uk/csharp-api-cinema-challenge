using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.GenericRepository;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("/tickets");
            ticketGroup.MapGet("", GetTickets);
            ticketGroup.MapGet("/{id}", GetTicketById);
        }

        private static async Task<IResult> GetTickets(IRepository<Ticket> repo)
        {
            var tickets = await repo.Get();
            return Results.Ok(tickets.Select(TicketDto));
        }

        private static async Task<IResult> GetTicketById(IRepository<Ticket> repo, object screeningId, object customerId)
        {
            var ticket = await repo.GetById(screeningId, customerId);
            if (ticket == null) return Results.NotFound();
            return Results.Ok(TicketDto(ticket));
            
        }
        private static object TicketDto(Ticket ticket)
        {
            var customer = ticket.Customer;
            var screening = ticket.Screening;
            var movie = screening.Movie;

            var movieDto = new
            {
                movie.Id,
                movie.Title,
                movie.Description,
                movie.Rating,
                movie.RuntimeMins,
                movie.CreatedAt,
                movie.UpdatedAt,
            };

            var screeningDto = new
            {
                screening.Id,
                screening.StartsAt,
                screening.Capacity,
                screening.CreatedAt,
                screening.UpdatedAt,
                screening.ScreenNumber,
                movieDto
            };

            var customerDto = new
            {
                customer.Id,
                customer.Name,
                customer.Email,
                customer.Phone,
                customer.CreatedAt,
                customer.UpdatedAt,
            };

            var ticketDto = new
            {
                customerDto,
                screeningDto,
                ticket.NumSeats,
                ticket.CreatedAt,
                ticket.UpdatedAt
            };

            return ticketDto;
        }
    }

}
