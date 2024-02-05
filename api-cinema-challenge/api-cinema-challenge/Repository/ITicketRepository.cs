using api_cinema_challenge.Models;
namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        public Task<IEnumerable<Ticket>> GetAllTickets(int customerid, int screeningid);

        public Task<Ticket> CreateTicket(int customerid, int screeningid, int numSeats);
    }
}
