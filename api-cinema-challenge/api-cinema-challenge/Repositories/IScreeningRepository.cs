using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Task<IEnumerable<Screening>> GetScreenings();
        Task<Screening> CreateScreening(int id, Screening screening);
    }
}
