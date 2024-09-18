using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITickets<Ticket>
    {
        private CinemaContext _db;

        public TicketRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Ticket> CreateEntity(Ticket entity)
        {
            if (entity == null)
                throw new InvalidOperationException("The ticket is not initiated, object null");
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;

        }

        public async Task<List<Ticket>> GetAllEntities(int customerId, int screeningId)
        {
            var targets = await _db.Ticket.Where(x => x.CustomerId == customerId).Where(y => y.ScreeningId == screeningId).ToListAsync();
            if (targets.Count == 0)
                throw new InvalidOperationException();

            return targets;
        }
    }
}
