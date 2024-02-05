using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        Task<Tickets?> CreateTicket(int SeatNr, int ScreeningId, int CustomerId);
        Task<IEnumerable<Tickets>> GetAllTickets();
    }
}
