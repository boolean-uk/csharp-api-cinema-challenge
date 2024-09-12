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
            return entity;
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            return await _db.Tickets
                .Include(x => x.Screening)
                .Include(x => x.Customer)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByScreening(int id)
        {
            var screeningTarget = await _db.Screenings
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (screeningTarget == null)
            {
                return Enumerable.Empty<Ticket>();
            }

            return screeningTarget.Tickets;
        }
    }
}
