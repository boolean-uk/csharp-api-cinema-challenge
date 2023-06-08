using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        public bool AddTicket(Ticket ticket)
        {
            using (var db = new CinemaContext())
            {
                ticket.CreatedAt = DateTime.UtcNow;
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Ticket> GetTickets()
        {
            using (var db = new CinemaContext())
            {
                return db.Tickets.Include(e => e.Screening).ThenInclude(s => s.Movie).Include(e => e.Screening).ThenInclude(s => s.Screen).Include(e => e.Customer).ToList();
            }
            return null;
        }
    }
}
