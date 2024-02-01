using api_cinema_challenge.Models;

namespace api_cinema_challenge.Controllers.ScreeningRepo
{
    public interface IScreeningRepository
    {

        Task<Screening?> CreateScreening(int id, int screenNumber, int capacity, DateTime startsAt);
        Task<Screening?> GetScreeningByMovieId(int movieId);

    }
}
