using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class TicketRepo : ITicketRepo
    {
        public bool AddTicket(Ticket ticket)
        {
            using (var db = new CinemaContext())
            {
                if (ticket != null)
                {
                    db.Tickets.Add(ticket);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            using (var db = new CinemaContext())
            {
                return db.Tickets.ToList();
            }
            return null;
        }
    }
}
