using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        Task<Screening> CreateScreening(Screening entity);
        Task<IEnumerable<Screening>> GetScreenings();
        Task<IEnumerable<Screening>> GetScreeningsByMovie(int id);
    }
}
