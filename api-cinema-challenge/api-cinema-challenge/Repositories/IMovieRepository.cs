using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMovies();

        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(int id, Movie movie);
        Task<Movie> DeleteMovie(int id);
        //Task<Screening> GetScreeningsByMovieId(int id);
    }
}
