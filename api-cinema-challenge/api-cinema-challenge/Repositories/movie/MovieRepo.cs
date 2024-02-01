using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepo : IMovieRepository
    {
        CinemaContext _db;
        public MovieRepo(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Movie> Add(string title, string rating, string description, int runttimeMins)
        {
            var newMovies = await _db.Movies.AddAsync(new Movie { Title = title, Rating = rating, Description = description, RuntimeMins = runttimeMins });
            await _db.SaveChangesAsync();
            return newMovies.Entity;
        }

        public async Task<Movie?> Delete(int id)
        {
            var movie = await Get(id);
            if (movie == null) { return null; }

            _db.Movies.Remove(movie);

            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie?> Get(int id)
        {
            var movie = await _db.Movies.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return movie;
        }

        public async Task<List<Movie>> GetAll()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie?> Update(int id, string title, string rating, string description, int runtimeMins)
        {
            var movie = await Get(id);
            if (movie == null) { return null; }

            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();

            return movie;
        }
    }
}
