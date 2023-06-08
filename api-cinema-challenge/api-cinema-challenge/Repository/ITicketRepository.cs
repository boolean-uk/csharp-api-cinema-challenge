using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetTickets();
        bool AddTicket(Ticket ticket);
    }
}
