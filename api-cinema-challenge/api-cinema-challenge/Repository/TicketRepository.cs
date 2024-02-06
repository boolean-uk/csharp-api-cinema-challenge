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

        public async Task<Ticket?> AddTicket(int customerId, int screeningId, int numberOfSeats)
        {
            var customer = await _db.Customers.Include(customer => customer.Tickets).FirstOrDefaultAsync(x => x.Id == customerId);
            if (customer == null)
            {
                return null;
            }

            var screening = await _db.Screenings.Include(screening => screening.Tickets).FirstOrDefaultAsync(x => x.Id ==  screeningId);
            if (screening == null)
            {
                return null;
            }

            Ticket ticket = new Ticket
            {
                CustomerId = customerId,
                Customer = customer,
                ScreeningId = screeningId,
                Screening = screening,
                NumberOfSeats = numberOfSeats,
            };

            customer.Tickets.Add(ticket);
            screening.Tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }

        public async Task<ICollection<Ticket>?> GetTickets(int id)
        {
            var customer = await _db.Customers.Include(c => c.Tickets).FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return null;
            }

            return customer.Tickets;
        }
    }
}
