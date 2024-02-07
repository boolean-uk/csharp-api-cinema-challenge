using api_cinema_challenge.Models.NewFolder;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        public Task<IEnumerable<Movie>> GetMovies();
    }
}
