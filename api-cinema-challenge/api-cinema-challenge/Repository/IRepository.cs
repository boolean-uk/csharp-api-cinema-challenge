using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.NewFolder;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        public Task<IEnumerable<Movie>> GetMovies();
        public Task<Movie> CreateMovie(MovieInputDTO input);
        public Task<Movie> UpdateMovie(MovieInputDTO input, int id);
        public Task<Movie> DeleteMovie(int id);
    }
}
