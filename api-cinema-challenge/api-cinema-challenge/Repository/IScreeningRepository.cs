using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        Task<Screening> CreateScreening(Screening entity);
        Task<IEnumerable<Screening>> GetScreenings();
        Task<IEnumerable<Screening>> GetScreeningsByMovie(int id);
        Task<Screening> GetScreeningById(int id);
        Task<Screening> UpdateScreening(int id, Screening entity);
        Task<Screening> DeleteScreening(int id);
    }
}
