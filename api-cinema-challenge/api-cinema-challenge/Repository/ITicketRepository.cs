using api_cinema_challange.Models;
namespace api_cinema_challange.Repository
{
    public interface ITicketRepository
    {
        public Task<IEnumerable<Ticket>> GetAllTickets();
    }
}
