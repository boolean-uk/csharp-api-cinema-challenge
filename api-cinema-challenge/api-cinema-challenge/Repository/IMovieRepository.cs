using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> CreateMovie(Movie request);

        Task<ICollection<Movie>> GetMovies();

        Task<Movie> UpdateMovie(Movie movie);

        Task<Movie> GetMovieById(int id);

        Task<Movie> DeleteMovie(Movie movie);
    }
}
