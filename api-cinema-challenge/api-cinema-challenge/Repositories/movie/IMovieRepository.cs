using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        public Task<Movie> Add(string title, string rating, string description, int runtimeMins);
        public Task<List<Movie>> GetAll();
        public Task<Movie?> Get(int id);
        public Task<Movie?> Update(int id, string title, string rating, string description, int runtimeMins);
        public Task<Movie?> Delete(int id);
    }
}
