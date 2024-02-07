using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetMovie(int id);
        Task<Movie> CreateMovie(string title , string rating , string description , int runtimeMins);
        Task<Movie> UpdateMovie(int id , string title , string rating , string description , int runtimeMins);
        Task<Movie> DeleteMovie(int id);
    }
}
