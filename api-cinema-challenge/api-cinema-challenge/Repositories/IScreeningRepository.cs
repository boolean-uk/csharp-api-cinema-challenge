using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Task<IEnumerable<Screening>> GetAllScreenings();
        Task<IEnumerable<Screening>> GetScreeningsByMovieId(int id);
        Task<Screening> GetScreeningById(int id);
        Task<Screening> CreateScreening(Screening screening);
        Task<Screening> UpdateScreening(int id, Screening newValues);
        Task DeleteScreening(int id);
    }
}
