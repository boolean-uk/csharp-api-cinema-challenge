using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposities.TicketRepo
{
    public interface ITicketRepository
    {
        Task<Ticket?> saveTicket(Ticket ticket);
        Task<IEnumerable<Ticket>> getAllTickets(int user_id, int screening_id);
    }
}
