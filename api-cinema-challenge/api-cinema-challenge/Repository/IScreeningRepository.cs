using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        public Task<Screening?> AddScreening(int id, Screening screening);
        public Task<IEnumerable<Screening>?> GetAllScreenings(int id);
    }
}
