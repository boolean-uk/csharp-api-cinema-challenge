
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace api_cinema_challenge.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly CinemaContext _db;

        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            await _db.Tickets.AddAsync(ticket);
            await _db.SaveChangesAsync();
            return await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .FirstOrDefaultAsync(x => x.Id == ticket.Id);

        }

        public async Task DeleteTicket(int id)
        {
            Ticket target = await _db.Tickets
               .Include(x => x.Customer)
               .Include(x => x.Screening)
               .ThenInclude(x => x.Movie)
               .FirstOrDefaultAsync(x => x.Id == id);

            _db.Tickets.Remove(target);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .ToListAsync();
        }

        public async Task<Ticket> GetTicketById(int id)
        {
            return await _db.Tickets
               .Include(x => x.Customer)
               .Include(x => x.Screening)
               .ThenInclude(x => x.Movie)
               .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByScreeningId(int id)
        {
            return await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .Where(x => x.ScreeningId == id)
                .ToListAsync();
        }
    }
}
