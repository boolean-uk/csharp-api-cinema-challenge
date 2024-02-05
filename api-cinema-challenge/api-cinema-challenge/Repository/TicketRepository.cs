using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _db;
        public TicketRepository(CinemaContext db) 
        {
            _db = db;
        }

        public async Task<Tickets?> CreateTicket(int SeatNr, int ScreeningId, int CustomerId)
        {
            //Create ticket to return
            Tickets ticket = new Tickets();
            //Check data is valid: seat is within capacity, screening exists, customer exists
            var screening = await _db.Screenings.SingleOrDefaultAsync(x => x.Id == ScreeningId);
            var customer = await _db.Customers.SingleOrDefaultAsync(y => y.Id == CustomerId);
            //Validate that seat is not taken
            foreach (var booking in _db.Tickets)
            {
                if (booking.SeatNr == SeatNr)
                {
                    return null;
                }
            }
            //if (screening.Id == null || SeatNr == null || ScreeningId == null || CustomerId == null)
            //{
            //    return null;
            //}
            if (SeatNr <= screening.Capacity && ScreeningId == screening.Id && CustomerId == customer.Id)
            {
                //Populate the ticket with payload data
                ticket.SeatNr = SeatNr;
                ticket.ScreeningId = ScreeningId;
                ticket.CustomerId = CustomerId;
            }
            //add ticket to database and save it + return
            _db.Tickets.Add(ticket);
            _db.SaveChanges();
            return ticket;
        }

        public async Task<IEnumerable<Tickets>> GetAllTickets(int screeningId, int customerId) //Add customerId aswell
        {
            return await _db.Tickets.Where(x => x.ScreeningId == screeningId && x.CustomerId == customerId).ToListAsync();
        }
    }
}
