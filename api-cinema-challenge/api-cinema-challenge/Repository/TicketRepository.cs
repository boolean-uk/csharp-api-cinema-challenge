using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _db;

        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            var exists = await _db.Tickets
                .Where(t => t.CustomerId == ticket.CustomerId)
                .Where(t => t.ScreeningId == ticket.ScreeningId)
                .AnyAsync();

            if (exists) return null;

            await _db.Tickets.AddAsync(ticket);
            await _db.SaveChangesAsync();

            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetByIdAsync(int customerId, int screeningId)
        {
            bool exists = await _db.Tickets
                .Where(t => t.CustomerId == customerId)
                .Where(t => t.ScreeningId == screeningId)
                .AnyAsync();

            if (!exists)
                return null;

            var tickets = await _db.Tickets
                .Where(t => t.CustomerId == customerId)
                .Where(t => t.ScreeningId==screeningId)
                .ToListAsync();

            return tickets;
        }
    }
}
