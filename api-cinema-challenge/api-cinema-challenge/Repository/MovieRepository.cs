using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Repository {

    public class MovieRepository : IMovieRepository
    {
        public Task<Movie> CreateMovie(string title, string rating, string description, string runtimeMins)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}