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

        public async Task<Ticket> AddTicket(int customerId, int screeningId, int numberOfSeats)
        {
            var customer = await _db.Customers.Include(customer => customer.Tickets).FirstOrDefaultAsync(x => x.Id == customerId);
            if (customer == null)
            {
                throw new Exception($"Customer with customer id {customerId} could not be found");
            }

            var screening = await _db.Screenings.Include(screening => screening.Tickets).FirstOrDefaultAsync(x => x.Id ==  screeningId);
            if (screening == null)
            {
                throw new Exception($"Screening with screening id {screeningId} could not be found");
            }

            if (screening.AvailableSeats - numberOfSeats < 0)
            {
                throw new Exception($"Not enough tickets available for this screening: only {screening.AvailableSeats} available");
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
            screening.AvailableSeats -= numberOfSeats;
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
