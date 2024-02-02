
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interface {
    public interface ITicketRepository
    {
        Task<Ticket?> CreateTicket(int customerId, int screeningId, List<CreateSeatPayload> seats);
        Task<Ticket?> GetTicket(int id);
        Task<IEnumerable<Ticket>> GetTicketsByCustomerId(int customerId);
        Task<IEnumerable<Ticket>> GetTicketsByScreeningId(int screeningId);
        Task DeleteTicket(int id);
    }
}
