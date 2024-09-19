using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> AddAsync(Movie entity);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> UpdateAsync(Movie entity);
        Task<Movie> DeleteAsync(int id);
        Task<string> GetTitleById(int id);
    }
}
