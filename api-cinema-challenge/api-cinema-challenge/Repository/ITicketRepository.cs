using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        public Task<Ticket?> AddTicket(int customerId, int screeningId, int numOfSeats);
        public Task<ICollection<Ticket>?> GetTickets(int id);
    }
}
