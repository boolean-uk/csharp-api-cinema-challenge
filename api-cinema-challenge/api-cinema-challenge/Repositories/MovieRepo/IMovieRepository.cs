using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposities.MovieRepo
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> getAllMovies();
        Task<Movie?> getMovieById(int id);
        Task<Movie?> createMovie(string title, string rating, string description, int runtime);
        Task<Movie?> updateMovie(int movie_id, string? title, string? rating, string? description, int? runtime);
        Task<Movie?> deleteMovie(int movie_id);
    }
}
