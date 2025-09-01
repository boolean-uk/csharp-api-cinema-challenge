using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly CinemaContext _ctx;
        public TicketRepository(CinemaContext ctx) => _ctx = ctx;

        public async Task<Ticket> AddAsync(Ticket t)
        {
            _ctx.Tickets.Add(t);
            await _ctx.SaveChangesAsync();
            return t;
        }

        public Task<List<Ticket>> GetByScreeningAsync(int screeningId)
            => _ctx.Tickets.AsNoTracking()
                .Where(t => t.ScreeningId == screeningId)
                .ToListAsync();
    }
}
