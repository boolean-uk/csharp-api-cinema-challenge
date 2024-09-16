using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(int id, Movie newValues);
        Task DeleteMovie(int id);
    }
}
