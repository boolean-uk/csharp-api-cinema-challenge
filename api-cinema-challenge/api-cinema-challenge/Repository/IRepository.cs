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
        // Task<Screening?> GetScreening(int screeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Screening?> CreateScreening(int screennumber, int capacity, DateTime datetime, int movieId);
        // Task<Screening?> DeleteScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        // Task<Screening?> UpdateScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);


        // TICKETS
        Task<IEnumerable<Ticket>> GetTickets(int custId, int screenId);
        // Task<Screening?> GetScreening(int screeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Ticket?> CreateTicket(int custId, int screenId, int seatNums);
        // Task<Screening?> DeleteScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        // Task<Screening?> UpdateScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);

        public void SaveChanges();

    }
}
