using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Reposities.TicketRepo
{
    public class TicketRepository : ITicketRepository
    {

        private CinemaContext _db;

        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Ticket?> saveTicket(Ticket ticket)
        {
            _db.Tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return ticket; 
        }

        public async Task<IEnumerable<Ticket>> getAllTickets(int user_id, int screening_id)
        {
            return await _db.Tickets.Include(a => a.User)
                .Include(a => a.Screening)
                .Where(a => a.userId == user_id && a.screeningId == screening_id)
                .ToListAsync();
        }

    }
}
