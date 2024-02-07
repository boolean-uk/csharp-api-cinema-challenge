using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetAllTickets();
        Task<Ticket> GetTicket(int id);
        Task<Ticket> CreateTicket(Ticket ticket);
        Task<Ticket> UpdateTicket(int id , Ticket ticket);
        Task<Ticket> DeleteTicket(int id);

    }
}
