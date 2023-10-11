using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepo
    {
        bool AddTicket(Ticket ticket);
        IEnumerable<Ticket> GetAllTickets();
    }
}
