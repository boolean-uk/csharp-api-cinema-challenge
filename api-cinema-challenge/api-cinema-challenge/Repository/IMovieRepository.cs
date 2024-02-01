using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAll();
        Task<Movie?> GetMovieById(int id);
        Task<Movie> CreateAMovie(Movie movie);
        Task<Movie?> UpdateAMovie(int id, string title, string description, string rating, int runtimeMins);
        Task<Movie?> DeleteAMovie(int id);
        
    }
}
