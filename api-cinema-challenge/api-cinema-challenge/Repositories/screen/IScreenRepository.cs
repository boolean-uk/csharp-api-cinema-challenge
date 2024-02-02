using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories.customer
{
    public interface IScreenRepository
    {
        public Task<Screen?> Add(int capacity);
        public Task<List<Screen>> GetAll();
        public Task<Screen?> Remove(int screenId);

    }
}
