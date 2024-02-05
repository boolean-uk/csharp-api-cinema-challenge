using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using System.Numerics;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _databaseContext;
        public TicketRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<List<Ticket?>> GetTickets(int customerId, int screeningId)
        {
            var customers = await _databaseContext.Customers.Include(t => t.Tickets).FirstOrDefaultAsync(t => t.Id == customerId);
            if (customers == null)
                return null;

            List<Ticket> tickets = new List<Ticket>();
            foreach (Ticket ticket in customers.Tickets.ToList())
            {
                if (ticket.ScreeningId == screeningId)
                    tickets.Add(ticket);
            }

            return tickets;
        }

        public async Task<Ticket?> BookATicket(int numSeats, int customerId, int screeningId)
        {
            List<Ticket> tickets = _databaseContext.Tickets.ToList();
            int id = 0;

            if (tickets.Count > 0)
                id = tickets.Last().Id;
            id++;

            Ticket newTicket = new Ticket() { Id = id, NumSeats = numSeats, ScreeningId = screeningId, CustomerId = customerId };
            await _databaseContext.AddAsync(newTicket);
            await _databaseContext.SaveChangesAsync();
            return newTicket;
        }
    }
}