using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CinemaContext _ctx;
        public MovieRepository(CinemaContext ctx) => _ctx = ctx;

        public async Task<Movie> AddAsync(Movie m)
        {
            _ctx.Movies.Add(m);
            await _ctx.SaveChangesAsync();
            return m;
        }

        public Task<List<Movie>> GetAllAsync()
            => _ctx.Movies.AsNoTracking().ToListAsync();

        public Task<Movie?> GetAsync(int id)
            => _ctx.Movies.FindAsync(id).AsTask();

        public async Task<Movie?> UpdateAsync(int id, Movie update)
        {
            var m = await _ctx.Movies.FindAsync(id);
            if (m == null) return null;
            m.Title = update.Title; m.Rating = update.Rating; m.Description = update.Description; m.RuntimeMins = update.RuntimeMins;
            await _ctx.SaveChangesAsync();
            return m;
        }

        public async Task<Movie?> DeleteAsync(int id)
        {
            var m = await _ctx.Movies.FindAsync(id);
            if (m == null) return null;
            _ctx.Movies.Remove(m);
            await _ctx.SaveChangesAsync();
            return m;
        }
    }
}
