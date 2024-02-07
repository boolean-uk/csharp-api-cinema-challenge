using api_cinema_challenge.Data;
using api_cinema_challenge.Models.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }
        public Task<IEnumerable<Movie>> GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}
