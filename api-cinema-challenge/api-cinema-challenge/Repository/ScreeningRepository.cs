using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Repository {

    public class ScreeningRepository : IScreeningRepository
    {
        public Task<Screening> CreateScreening(int screenNumber, int capacity, DateTime startsAt, DateTime endsAt, int movieId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteScreening(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Screening>> GetAllScreenings()
        {
            throw new NotImplementedException();
        }

        public Task<Screening> GetScreening(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateScreening(int id, Screening screening)
        {
            throw new NotImplementedException();
        }
    }
}