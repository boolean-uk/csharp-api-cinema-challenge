using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ITicketRepository
    {
        Ticket CreateTicket(int customerId, int screeningId, TicketPost t);
    }
}
