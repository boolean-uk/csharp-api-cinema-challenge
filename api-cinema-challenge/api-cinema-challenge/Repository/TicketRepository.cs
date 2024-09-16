using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _db;
        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Ticket>> GetCustomerTicketsByScreening(int customerId, int screeningId)
        {
            return await _db.Tickets
           .Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId)
           .ToListAsync();
        }

        public async Task<Ticket> AddTicket(Ticket ticket)
        {
            _db.Add(ticket);

            await _db.SaveChangesAsync();

            return ticket;
        }

    }
}
