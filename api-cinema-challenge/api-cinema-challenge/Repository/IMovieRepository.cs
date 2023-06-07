using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        bool AddMovie(Movie movie);
        bool UpdateMovie(Movie movie);
        bool DeleteMovie(int id);
    }
}
