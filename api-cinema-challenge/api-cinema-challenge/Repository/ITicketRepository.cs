using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetCustomerTicketsByScreening(int customerId, int screeningId);

        Task<Ticket> AddTicket(Ticket ticket);
    }
}
