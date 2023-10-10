using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepo
    {
        bool AddScreening(Screening screening);
        IEnumerable<Screening> GetAllScreenings();
    }
}
