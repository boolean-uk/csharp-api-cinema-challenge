using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _cinemaContext;
        public TicketRepository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Ticket> CreateTicket(int numSeats, Customer customer, Screening screening)
        {
            Ticket ticket = new Ticket();
            ticket.NumSeats = numSeats;
            ticket.UpdatedAt = DateTime.Now.ToUniversalTime();
            ticket.CreatedAt = DateTime.Now.ToUniversalTime();
            ticket.ScreeningId = screening.Id;
            ticket.CustomerId = customer.Id;
            await _cinemaContext.Tickets.AddAsync(ticket);
            _cinemaContext.SaveChanges();
            return ticket;
        }

        public async Task<ICollection<Ticket>> GetTickets(int customerID, int screeningID)
        {
            return await _cinemaContext.Tickets.Where(x => x.CustomerId == customerID && x.ScreeningId == screeningID).Include(x => x.Screening).ThenInclude(x => x.Movie).ToListAsync();
        }

        public async Task<ICollection<Ticket>> GetTicketsbyCustomer(Customer customer)
        {
            return await _cinemaContext.Tickets.Where(x => x.CustomerId == customer.Id).Include(x => x.Screening).ThenInclude(x => x.Movie).ToListAsync();
        }

        public async Task<ICollection<Ticket>> GetTicketsbyScreening(Screening screening)
        {
            return await _cinemaContext.Tickets.Where(x => x.ScreeningId == screening.Id).Include(x=>x.Customer).Include(x => x.Screening).ThenInclude(x => x.Movie).ToListAsync();
        }
    }
}
