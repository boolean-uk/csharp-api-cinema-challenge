using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposities.MovieRepo
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie?> GetMovieById(int id);
        Task<Movie?> CreateMovie(string title, string rating, string description, int runtime);
        Task<Movie?> UpdateMovie(int movie_id, string? title, string? rating, string? description, int? runtime);
        Task<Movie?> DeleteMovie(int movie_id);
    }
}
