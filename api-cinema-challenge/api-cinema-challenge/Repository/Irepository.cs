using api_cinema_challenge.Models;
using System.Numerics;
using System.Threading.Tasks;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<User>> GetUsers();

        Task<IEnumerable<Movie>> GetMovies();

        Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId);

        
    }
}
