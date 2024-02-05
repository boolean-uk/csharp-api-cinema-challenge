using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposities.ScreeningRepo
{
    public interface IScreeningRepository
    {

        Task<Screening?> createScreening(int id, int screenNumber, int capacity, DateTime startsAt);
        Task<Screening?> getScreeningByMovieId(int movieId);
        Task<Screening?> getScreeningById(int screening_id);

    }
}
