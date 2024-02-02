using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

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
    }
}
