using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories.customer
{
    public interface IScreeningRepository
    {
        public Task<Screening?> Add(int movieId, int screenNumber, DateTime startsAt, float price);
        public Task<List<Screening>> GetAll(int movieId);

    }
}
