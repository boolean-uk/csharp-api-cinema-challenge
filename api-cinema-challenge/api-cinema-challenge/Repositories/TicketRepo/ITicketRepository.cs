using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposities.TicketRepo
{
    public interface ITicketRepository
    {
        Task<Ticket?> SaveTicket(Ticket ticket);
        Task<IEnumerable<Ticket>> GetAllTickets(int user_id, int screening_id);
    }
}
