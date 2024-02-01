using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        public Task<IEnumerable<Screening>> GetScreenings(int movieID);
        public Task<Screening> CreateScreening(int movieID, int screenNumber, int capacity, DateTime startsAt);
    }
}
