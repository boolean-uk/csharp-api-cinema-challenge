using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _context;
        public Repository(CinemaContext db) 
        {
            _context = db;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId)
        {
            return await _context.Screens
                .Where(s => s.MovieId == movieId).ToListAsync();
        }
    }
}
