using System.Linq.Expressions;
using api_cinema_challenge.Models;


namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();

        Task<Movie> AddMovie(Movie movie);

        Task<Movie> UpdateMovie(int id, Movie movie);

        Task<Movie> DeleteMovie(int id);
    }
}