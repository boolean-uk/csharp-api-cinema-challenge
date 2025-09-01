using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket> AddAsync(Ticket t);
        Task<List<Ticket>> GetByScreeningAsync(int screeningId);
    }
}
