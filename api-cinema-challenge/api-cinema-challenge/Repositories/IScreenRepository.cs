using api_cinema_challenge.Models.DatabaseModels;

namespace api_cinema_challenge.Repositories
{
    public interface IScreenRepository
    {
        Task<IEnumerable<Screen>> GetScreenings();
        Task<Screen> GetScreenById(int id);
        Task<Screen> CreateScreen (Screen screen);
        Task<Screen> UpdateScreen (Screen screen, int id);
        Task<Screen> DeleteScreen (int id);
    }
}
