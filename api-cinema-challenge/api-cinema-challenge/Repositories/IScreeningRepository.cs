using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Screening CreateScreening(int movieId, ScreeningPost s);
        IEnumerable<Screening> GetScreenings(int movieId);
    }
}
