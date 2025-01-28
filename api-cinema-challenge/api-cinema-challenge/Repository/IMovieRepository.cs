using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {

        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovieById(int movieId);
        Task DeleteMovie(int movieId);


        Task<IEnumerable<Screening>> GetScreenings();
        Task<Screening> CreateScreenings();






    }
}