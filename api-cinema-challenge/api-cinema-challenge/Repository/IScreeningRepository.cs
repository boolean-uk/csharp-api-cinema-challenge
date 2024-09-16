using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        Task<IEnumerable<Screening>> GetScreeningsByMovie(int movieId);

        Task<Screening> AddScreening(int id, Screening screening);
    }
}
