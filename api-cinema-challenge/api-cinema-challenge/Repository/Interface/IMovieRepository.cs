
using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interface {

    public interface IMovieRepository
    {
        Task<Movie> CreateMovie (string title, string rating, string description, string runtimeMins);
        public Task<Movie?> GetMovie(int id);
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> UpdateMovie(int id, Movie movie);
        Task<Movie> DeleteMovie(int id);
    }

}