using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace api_cinema_challenge.Controllers.MovieRepo
{
    public class MovieRepository : IMovieRepository
    {


        private CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Movie?> CreateMovie(string title, string rating, string description, int runtime)
        {
            if (title == null || title == "")
            {
                return null;
            }
            if (rating == null || rating == "")
            {
                return null;
            }
            if (description == null || description == "")
            {
                return null;
            }
            if (runtime <= 0) {
                return null;
            }
            var result = new Movie() { Title = title, Rating = rating, Description = description, RuntimeMins = runtime, Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow };
            _db.Movies.Add(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<Movie?> DeleteMovie(int movie_id)
        {
            var result = await GetMovieById(movie_id);
            if (result == null)
            {
                return null;
            }
            _db.Movies.Remove(result);
            await _db.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie?> GetMovieById(int id)
        {
            return await _db.Movies.FindAsync(id);
        }

        public async Task<Movie?> UpdateMovie(int movie_id, string? title, string? rating, string? description, int? runtime)
        {
            Movie? movie = await GetMovieById(movie_id);
            if (movie == null)
            {
                return null;
            }
            if (title == "")
            {
                return null;
            }
            if (rating == "")
            {
                return null;
            }
            if (description == "")
            {
                return null;
            }
            if (runtime <= 0) {
                return null;
            }

            if (title != null)
            {
                movie.Title = title;
                movie.Updated_at = DateTime.UtcNow;
            }
            if (rating != null)
            {
                movie.Rating = rating;
                movie.Updated_at = DateTime.UtcNow;
            }
            if (description != null)
            {
                movie.Description = description;
                movie.Updated_at = DateTime.UtcNow;
            }
            if (runtime > 0) {
                movie.RuntimeMins = runtime.Value;
                movie.Updated_at = DateTime.UtcNow;
            }
            await _db.SaveChangesAsync();
            return movie;
        }
    }
}
