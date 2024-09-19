using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepository : IMovieRepository
    {

        private readonly CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();
            return await _db.Movies
                .Include(m => m.Screenings)
                .FirstOrDefaultAsync(m => m.Id == movie.Id);
        }

        public async Task DeleteMovie(int id)
        {
            Movie target = await _db.Movies.FindAsync(id);
            _db.Movies.Remove(target);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies
                .Include(m => m.Screenings)
                .ToListAsync();
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _db.Movies
                .Include(m => m.Screenings)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movie> UpdateMovie(int id, Movie newValues)
        {
            Movie target = await _db.Movies
                .Include(m => m.Screenings)
                .FirstOrDefaultAsync(m => m.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.Title = newValues.Title;
            target.Rating = newValues.Rating;
            target.Description = newValues.Description;

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return target;
        }
    }
}
