using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _db;
        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Ticket> CreateTicket(int numSeats, int customerId, int screeningId)
        {
            Ticket ticket = new Ticket()
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                NumSeats = numSeats,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime()
            };

            _db.tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }

        public async Task<ICollection<Ticket>> GetTickets(int screeningId, int customerId)
        {
            return await _db.tickets.Where(t => t.ScreeningId == screeningId && t.CustomerId == customerId).ToListAsync()
                ?? throw new ArgumentException("No such customer or screening");
        }
    }
}
