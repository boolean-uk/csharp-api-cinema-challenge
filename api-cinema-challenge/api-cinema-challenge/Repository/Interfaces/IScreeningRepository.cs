using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface IScreeningRepository
    {
        public Task<IEnumerable<Screening>> GetByIdAsync(int movieId);
        public Task<Screening> CreateScreening(Screening screening);
    }
}
