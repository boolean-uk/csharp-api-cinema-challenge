using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        IEnumerable<Screening> GetScreenings();
        bool AddScreening(Screening screening);
    }
}
