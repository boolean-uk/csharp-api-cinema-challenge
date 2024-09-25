using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreening
    {
        public Task<IEnumerable<Screening>> GetAll(int movieId);
        public Task<Screening> Create(Screening entity);
    }
}
