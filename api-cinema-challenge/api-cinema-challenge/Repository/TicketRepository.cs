using api_cinema_challange.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challange.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _databaseContext;
        public TicketRepository(CinemaContext db)
        {
            _databaseContext = db;
        }
        public async Task<IEnumerable<Ticket>> GetAllTickets(){
            return await _databaseContext.Tickets.ToListAsync();
        }
    }
}
