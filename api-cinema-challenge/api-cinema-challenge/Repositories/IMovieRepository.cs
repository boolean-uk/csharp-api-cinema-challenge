using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> AddAsync(Movie m);
        Task<List<Movie>> GetAllAsync();
        Task<Movie?> GetAsync(int id);
        Task<Movie?> UpdateAsync(int id, Movie update);
        Task<Movie?> DeleteAsync(int id);
    }
}
