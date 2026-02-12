using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.GenericRepositories;

namespace api_cinema_challenge.Repositories.SpecificRepositories
{
    public interface IScreeningRepository : IRepository<Screening>
    {
        Task<IEnumerable<Screening>> GetScreeningsByMovieAsync(int movieId);
    }
}
