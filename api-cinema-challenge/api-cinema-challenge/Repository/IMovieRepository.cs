using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Posts;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        public Task<Movie> AddMovie(Movie movie);
        public Task<ICollection<Movie>> GetAllMovies();
        public Task<Movie?> UpdateMovie(int id, MoviePut movie);
        public Task<Movie?> DeleteMovie(int id);
    }
}
