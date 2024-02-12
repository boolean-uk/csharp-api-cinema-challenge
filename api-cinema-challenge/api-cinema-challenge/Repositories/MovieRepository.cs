using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Movie> CreateMovie(Movie movie)
        {
            movie.CreatedAt = DateTime.UtcNow;
            movie.UpdatedAt = DateTime.UtcNow;
            _db.Movies.Add(movie);
            _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await GetMovieById(id);
            _db.Movies.Remove(movie);
            _db.Remove(movie);
            _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _db.Movies.Include(s => s.Screenings).FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.Include(s => s.Screenings).ToListAsync();
        }

        public async Task<Movie> UpdateMovie(int id, Movie movie)
        {
            var aMovie = await GetMovieById(id);

            aMovie.Title = movie.Title;
            aMovie.Runtime = movie.Runtime;
            aMovie.Screenings = movie.Screenings;
            aMovie.Rating = movie.Rating;
            aMovie.Description = movie.Description;
            aMovie.UpdatedAt = DateTime.UtcNow;
            _db.SaveChangesAsync();
            return aMovie;

        }

  
    }
}
