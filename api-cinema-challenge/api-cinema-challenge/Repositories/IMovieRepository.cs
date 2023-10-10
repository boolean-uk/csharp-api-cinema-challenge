using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Movie CreateMovie(MoviePost m);
        IEnumerable<Movie> GetMovies();
        Movie UpdateMovie(int id, MoviePut movieFields);
    }
}
