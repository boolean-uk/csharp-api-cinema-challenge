using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        Task<Screening> AddAsync(Screening entity);
        Task<IEnumerable<Screening>> GetScreenings(int id);
        Task<Screening> GetScreeningById (int id);
    }
}
