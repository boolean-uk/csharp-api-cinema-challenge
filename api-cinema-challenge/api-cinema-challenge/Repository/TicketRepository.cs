using api_cinema_challenge.Data;
using api_cinema_challenge.DOTs.TicketDTO;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository
    {
        private CinemaContext _db;
        public TicketRepository(CinemaContext context)
        {
            _db = context;

        }

        public async Task<Ticket> Book(TicketPost ticketPost, int customerId, int screeningId)
        {
            Ticket ticket = new Ticket(ticketPost, customerId, screeningId);
            _db.Tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }
    }
}
