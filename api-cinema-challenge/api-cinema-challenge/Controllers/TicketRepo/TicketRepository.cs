using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Controllers.TicketRepo
{
    public class TicketRepository : ITicketRepository
    {

        private CinemaContext _db;

        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Ticket?> SaveTicket(Ticket ticket)
        {
            _db.Tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return ticket; 
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets(int user_id, int screening_id)
        {
            return await _db.Tickets.Include(a => a.User)
                .Include(a => a.Screening)
                .Where(a => a.UserId == user_id && a.ScreeningId == screening_id)
                .ToListAsync();
        }

    }
}
