using api_cinema_challange.Models;

namespace api_cinema_challange.Repository
{
    public interface IMovieRepository
    {
        public Task<IEnumerable<Movie>> GetAllMovies();
        public Task<Movie?> CreateAMovie(string title, string rating, string description, int runtimeMins, List<MovieScreeningPostPayload>? screenings = null);

        public Task<Movie?> UpdateMovie(int movieid, string title, string rating, string description, int runtimeMins);

        public Task<Movie?> GetMovieById(int movieid);

        public Task<Movie?> DeleteMovie(int movieid);

    }
}
