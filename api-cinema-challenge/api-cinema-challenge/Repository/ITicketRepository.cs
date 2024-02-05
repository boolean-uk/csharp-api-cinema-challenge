using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        Task<List<Ticket?>> GetTickets(int customerId, int screeningId);
        Task<Ticket?> BookATicket(int numSeats, int customerId, int screeningId);
    }
}