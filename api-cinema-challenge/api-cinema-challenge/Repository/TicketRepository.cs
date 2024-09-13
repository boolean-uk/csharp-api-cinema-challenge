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
            Ticket ticket = null; // id is wrong, fix
            if (_db.Tickets.Where(x => x.Id == id).Count() > 0 && _db.Tickets.Where(x => x.Id == ticket.Id).Min(x => x.numSeats) - 1 >= 0)
            {
                _db.Tickets.Add(ticket = new Ticket() { Id = id, numSeats = _db.Tickets.Where(x => x.Id == ticket.Id).Min(x => x.numSeats) - 1 });
            }
            else
            {
                _db.Tickets.Add(ticket = new Ticket() { Id = id, numSeats = _db.Screenings.FirstOrDefault(x => x.Id == ticket.Id).Capacity - 1 });
            }
            return ticket != null ? ticket.MapToDTO() : null;
        }
        public List<TicketDTO> GetTickets()
        {
            return _db.Tickets.ToList().MapListToDTO();

        }
    }
}
