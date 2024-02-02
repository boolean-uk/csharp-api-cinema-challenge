using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetMovies();
        Task<Movie?> GetMovie(int id);
        Task<Movie?> CreateMovie(string title, string rating, string description, int runtimeMins);
        Task<Movie>? UpdateMovie(Movie customer, string? title, string? rating, string? description, int? runtimeMins);
        Task<List<Movie>> DeleteMovie(Movie movie);
    }
}