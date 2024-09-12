using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> CreateMovie(Movie entity);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> UpdateMovie(int id, Movie entity);
        Task<Movie> DeleteMovie(int id);
    }
}
