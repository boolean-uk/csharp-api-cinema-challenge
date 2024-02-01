using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningsRepository
    {
        Task<Screenings?> CreateScreening(int ScreenNr, int Capacity, DateTime StartsAt, int MoviesId);
        Task<IEnumerable<Screenings>> GetScreenings();
    }
}
