using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetAllTickets();
        Task<IEnumerable<Ticket>> GetTicketsByScreeningId(int id);
        Task<Ticket> GetTicketById(int id);
        Task<Ticket> CreateTicket(Ticket ticket);
        Task DeleteTicket(int id);
    }
}
