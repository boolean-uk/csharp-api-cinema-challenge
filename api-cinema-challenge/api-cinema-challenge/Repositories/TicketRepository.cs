using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public Ticket CreateTicket(int customerId, int screeningId, TicketPost t)
        {
            using (var db = new CinemaContext())
            {
                DateTime date = DateTime.UtcNow;
                Ticket ticket = new Ticket()
                {
                    numSeats = t.numSeats,
                    createdAt = date,
                    updatedAt = date,
                    customerId = customerId,
                    screeningId = screeningId
                };

                db.Tickets.Add(ticket);
                db.SaveChanges();
                return ticket;
            }
            return null;
        }
    }
}
