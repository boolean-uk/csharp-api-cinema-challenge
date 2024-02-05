using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{

    public enum PreloadPolicy
    {
        PreloadRelations,
        DoNotPreloadRelations
    }

    public interface IRepository
    {
        
        // SCREENINGS
        Task<IEnumerable<Screening>> GetScreenings(int id);
        Task<Screening?> CreateScreening(int screennumber, int capacity, DateTime datetime, int movieId);


        // TICKETS
        Task<IEnumerable<Ticket>> GetTickets(int custId, int screenId);
        Task<Ticket?> CreateTicket(int custId, int screenId, int seatNums);
        public void SaveChanges();

    }
}
