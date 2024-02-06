using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly CinemaContext _context;

        public TicketRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetTicket(int id)
        {
            return await _context.Tickets.FindAsync(id);
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return ticket;
        }

        public async Task<Ticket> DeleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if(ticket == null)
            {
                return null;
            }

            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return ticket;
        }

        public async Task<Ticket> UpdateTicket(int id , Ticket ticket)
        {
            var existingTicket = await _context.Tickets.FindAsync(id);
            if(existingTicket == null)
            {
                throw new ArgumentNullException(nameof(existingTicket) , "Ticket cannot be null.");
            }

            existingTicket.SeatId = ticket.SeatId;
            existingTicket.ScreeningId = ticket.ScreeningId;

            await _context.SaveChangesAsync();

            return existingTicket;
        }
    }
}
