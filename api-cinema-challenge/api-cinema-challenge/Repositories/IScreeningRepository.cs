using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Task<Screening> AddForMovieAsync(int movieId, Screening s);
        Task<List<Screening>> GetForMovieAsync(int movieId);
    }
}
