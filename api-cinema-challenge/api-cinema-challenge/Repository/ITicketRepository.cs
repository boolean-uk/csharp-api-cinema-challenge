using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {

        Task<Ticket> CreateTicket(int numSeats, int customerId, int screeningId);

        Task<ICollection<Ticket>> GetTickets(int screeningId, int customerId);
    }
}
