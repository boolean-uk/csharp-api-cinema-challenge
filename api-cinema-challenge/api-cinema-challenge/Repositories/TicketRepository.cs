using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Ticket> AddTicket(int screeningId)
        {
            var ticket = new Ticket(screeningId);
            await _db.Ticket.AddAsync(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }

        public async  Task<IEnumerable<Ticket>> GetTicket()
        {
            return await _db.Ticket.ToListAsync();
        }
    }
}
