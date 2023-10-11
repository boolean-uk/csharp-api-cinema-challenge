using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepo
    {
        bool AddMovie(Movie movie);
        IEnumerable<Movie> GetAllMovies();
        bool UpdateMovie(Movie movie);
        bool DeleteMovie(int id);
    }
}
