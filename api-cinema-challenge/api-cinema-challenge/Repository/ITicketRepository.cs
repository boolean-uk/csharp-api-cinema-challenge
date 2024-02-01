using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        public Task<Ticket?> CreateTicket(int numSeats, int customerID, int screeningID);
        public Task<ICollection<Ticket>?> GetTickets(int customerID, int screeningID);
    }
}
