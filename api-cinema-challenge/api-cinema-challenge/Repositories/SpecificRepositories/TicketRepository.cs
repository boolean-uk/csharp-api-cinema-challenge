using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Repositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace api_cinema_challenge.Repositories.SpecificRepositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {

        private readonly CinemaContext _context;

        public TicketRepository(CinemaContext dbContext) : base(dbContext) {

            _context = dbContext;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByCustomerAsync(int customerId)
        {
            return await _context.Set<Ticket>()
                .Where(t => t.CustomerId == customerId)
                .Include(t => t.Customer) 
                .Include(t => t.Screening)
                .ThenInclude(s => s.Movie) 
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByScreeningAsync(int screeningId)
        {
            return await _context.Set<Ticket>().Where(t => t.ScreeningId == screeningId).ToListAsync();
        }
    }
}
