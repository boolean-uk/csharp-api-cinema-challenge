using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMoviesRepository
    {
        Task<Movies?> CreateMovie(string title, string rating, string description, int runtime);
        Task<Movies?> GetMovie(int id);
        Task<IEnumerable<Movies>> GetMovies();
        Task<Movies?> UpdateMovie(int id, string? Title, string? Rating, string? Description, int? Runtime);
        Task<Movies?> DeleteMovie(int id);
    }
}
