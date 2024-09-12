using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Task<ICollection<Screening>> GetScreenings();
        Task<Screening> CreateScreening();
    }
}
