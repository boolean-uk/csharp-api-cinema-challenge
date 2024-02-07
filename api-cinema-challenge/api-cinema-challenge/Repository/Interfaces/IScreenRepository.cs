using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{

    public interface IScreenRepository
    {
        Task<IEnumerable<Screen>> GetAllScreens();
        Task<Screen> GetScreen(int id);
        Task<Screen> CreateScreen(Screen screen);
        Task<Screen> UpdateScreen(int id , Screen screen);
        Task<Screen> DeleteScreen(int id);
    }

}
