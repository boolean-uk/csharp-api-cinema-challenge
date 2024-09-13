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

        public async Task<Ticket> CreateTicket(Ticket entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .FirstOrDefaultAsync(x => x.Id == entity.Id);
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            return await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByScreening(int id)
        {
            var target = await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .Where(x => x.ScreeningId == id)
                .ToListAsync();

            if (target == null)
            {
                return Enumerable.Empty<Ticket>();
            }

            return target;
        }

        public async Task<Ticket> GetTicketById(int id)
        {
            return await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ticket> DeleteTicket(int id)
        {
            var target = await _db.Tickets
                .Include(x => x.Customer)
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (target == null)
            {
                return null;
            }

            _db.Tickets.Remove(target);
            await _db.SaveChangesAsync();
            return target;
        }
    }
}
