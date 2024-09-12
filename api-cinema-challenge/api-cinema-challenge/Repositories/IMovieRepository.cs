using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMovies();
        Task<Movie> CreateMovie();
        Task<Movie> UpdateMovie();
        Task<Movie> DeleteMovie();

    }
}
