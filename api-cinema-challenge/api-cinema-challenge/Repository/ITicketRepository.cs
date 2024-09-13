using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        Task<Ticket> CreateTicket(Ticket entity);
        Task<IEnumerable<Ticket>> GetTickets();
        Task<IEnumerable<Ticket>> GetTicketsByScreening(int id);
        Task<Ticket> GetTicketById(int id);
        Task<Ticket> DeleteTicket(int id);
    }
}
