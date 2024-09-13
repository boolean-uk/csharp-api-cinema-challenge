using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Payload;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository : IRepository<Ticket, TicketPayload>
    {
        private CinemaContext _db;
        public TicketRepository(CinemaContext context) 
        {
            _db = context;
        }
        public Task<Ticket> Create(TicketPayload entity)
        {
            throw new NotImplementedException();
        }


        public Task<Ticket> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> Update(TicketPayload entity, int id)
        {
            throw new NotImplementedException();
        }


        // Independent 
        public async Task<IEnumerable<Ticket>> GetTickets(int customerid, int screeningid)
        {
            return await _db.Tickets.Where(t => t.CustomerID == customerid && t.ScreeningId == screeningid).ToListAsync();
        }

        public async Task<Ticket> CreateTicket(TicketPayload entity, int customerid, int screeningid)
        {
            Ticket ticket = new Ticket()
            {
                NumSeats = entity.NumSeats,
                CreatedAT = DateTime.UtcNow,
                UpdatedAT = DateTime.UtcNow,
                ScreeningId = screeningid,
                CustomerID = customerid
            };

            await _db.AddAsync(ticket);
            await _db.SaveChangesAsync();

            return ticket;
        }
    }
}
