using api_cinema_challenge.Models;

namespace api_cinema_challenge.Controllers.TicketRepo
{
    public interface ITicketRepository
    {
        Task<Ticket?> SaveTicket(Ticket ticket);
        Task<IEnumerable<Ticket>> GetAllTickets(int user_id, int screening_id);
    }
}
