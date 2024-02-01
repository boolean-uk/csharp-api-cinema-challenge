using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _cinemaContext;
        public TicketRepository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Ticket?> CreateTicket(int numSeats, int customerID, int screeningID)
        {
            Screening? screening = await _cinemaContext.Screenings.FirstOrDefaultAsync(x => x.Id == screeningID);
            Customer? customer = await _cinemaContext.Customers.FirstOrDefaultAsync(x => x.Id == customerID);
            if (screening is null || customer is null) return null;
            Ticket ticket = new Ticket();
            ticket.NumSeats = numSeats;
            ticket.UpdatedAt = DateTime.Now.ToUniversalTime();
            ticket.CreatedAt = DateTime.Now.ToUniversalTime();
            ticket.ScreeningId = screeningID;
            ticket.CustomerId = customerID;
            await _cinemaContext.Tickets.AddAsync(ticket);
            _cinemaContext.SaveChanges();
            return ticket;
        }

        public Task<ICollection<Ticket>?> GetTickets(int customerID, int screeningID)
        {
            throw new NotImplementedException();
        }
    }
}
