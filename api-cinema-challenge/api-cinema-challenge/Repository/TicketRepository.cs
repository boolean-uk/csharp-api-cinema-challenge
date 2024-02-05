using api_cinema_challenge.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _databaseContext;
        public TicketRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Ticket> CreateTicket(int customerid, int screeningid, int numSeats)
        {
            Ticket ticket = new Ticket()
            {
                NumSeats = numSeats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _databaseContext.Tickets.Add(ticket);
            await _databaseContext.SaveChangesAsync();
            _databaseContext.CustomerTickets.Add(new CustomerTicket() { CustomerId = customerid, TicketId = ticket.Id });
            _databaseContext.ScreeningTickets.Add(new ScreeningTicket() { ScreeningId = screeningid, TicketId = ticket.Id });
            await _databaseContext.SaveChangesAsync();
            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets(int customerid, int screeningid)
        {
            var customerTicketIds = await _databaseContext.CustomerTickets
                .Where(ct => ct.CustomerId == customerid)
                .Select(ct => ct.TicketId)
                .ToListAsync();

            if (!customerTicketIds.Any())
                return null;

            var screeningTicketIds = await _databaseContext.ScreeningTickets
                .Where(st => customerTicketIds.Contains(st.TicketId) && st.ScreeningId == screeningid)
                .Select(st => st.TicketId)
                .ToListAsync();

            if (!screeningTicketIds.Any())
                return null;

            return await _databaseContext.Tickets
                .Where(t => screeningTicketIds.Contains(t.Id))
                .ToListAsync();
        }
    }
}
