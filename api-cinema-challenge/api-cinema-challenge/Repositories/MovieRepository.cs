using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }

        public Task<Movie> CreateMovie()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> DeleteMovie()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Movie>> GetMovies()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateMovie()
        {
            throw new NotImplementedException();
        }
    }
}
