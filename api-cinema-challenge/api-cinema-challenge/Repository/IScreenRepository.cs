using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreenRepository
    {
        IEnumerable<Screen> GetScreens();
        Screen GetScreen(int id);
        bool AddScreen(Screen screen);
        bool UpdateScreen(Screen screen);
        bool DeleteScreen(int id);
    }
}
