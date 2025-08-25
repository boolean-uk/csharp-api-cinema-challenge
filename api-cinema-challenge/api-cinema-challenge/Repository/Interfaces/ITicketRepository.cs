using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface ITicketRepository
    {
        public Task<IEnumerable<Ticket>> GetByIdAsync(int customerId, int screeningId);
        public Task<Ticket> CreateTicket(Ticket ticket);
    }
}
