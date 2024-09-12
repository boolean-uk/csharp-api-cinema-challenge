using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Models.Ticket;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public TicketDTO BookTicket(int id)
        {
            Ticket ticket = null;
            if (_db.Tickets.Where(x => x.Id == id).Count() > 0)
            {
                _db.Tickets.Add(ticket = new Ticket() { Id = _db.Tickets.Max(x => x.Id) + 1, numSeats = _db.Screenings.FirstOrDefault(x => x.Id == id).Capacity - _db.Tickets.Where(x => x.Id == id).Max(x => x.numSeats) });
            }
            else
            {
                _db.Tickets.Add(ticket = new Ticket() { Id = _db.Tickets.Max(x => x.Id) + 1, numSeats = _db.Screenings.FirstOrDefault(x => x.Id == id).Capacity - 1 });
            }
            return ticket != null ? ticket.MapToDTO() : null;
        }
        public List<TicketDTO> GetTickets()
        {
            return _db.Tickets.ToList().MapListToDTO();

        }
    }
}
