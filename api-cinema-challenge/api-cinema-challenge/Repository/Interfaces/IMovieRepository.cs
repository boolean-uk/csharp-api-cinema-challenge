using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface IMovieRepository
    {
        public Task<Movie> GetByIdAsync(int id);
        public Task<IEnumerable<Movie>> GetAllAsync();
        public Task<Movie> CreateMovie(Movie movie);
        public Task<Movie> UpdateMovie(Movie customer);
        public Task<Movie> DeleteMovie(int id);
    }
}
