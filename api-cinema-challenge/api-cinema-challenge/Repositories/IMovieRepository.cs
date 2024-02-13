using api_cinema_challenge.Models.DatabaseModels;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie, int id);
        Task<Movie> DeleteMovie(int id);
    }
}
