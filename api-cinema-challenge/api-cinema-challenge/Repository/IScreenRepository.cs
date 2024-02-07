using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreenRepository
    {

        public Task<Screen> CreateAScreen(Screen screen);
        public Task<Screen?> DeleteAScreen(int id);
        public Task<List<Screen>> GetAll();
        public Task<Screen?> UpdateAScreen(int id, string name);
        public Task<Screen?> GetScreenById(int id);



    }
}

