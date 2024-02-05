using api_cinema_challenge.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _databaseContext;
        public MovieRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Movie?> CreateAMovie(string title, string rating, string description, int runtimeMins, List<MovieScreeningPostPayload>? screenings)
        {
            Movie movie = new Movie()
            {
                Title = title,
                Rating = rating,
                Description = description,
                RuntimeMins = runtimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _databaseContext.Movies.Add(movie);
            await _databaseContext.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _databaseContext.Movies
            .Include(m => m.Screenings)
            .ToListAsync();
        }
        public async Task<Movie?> GetAMovie(int movieId)
        {
            Movie? movie = await _databaseContext.Movies
                .Where(m => m.Id == movieId)
                .Include(m => m.Screenings)
                .FirstOrDefaultAsync();
            if (movie == null)
            {
                return null;
            }
            return movie;
        }

        public async Task<Movie?> GetMovieById(int movieid)
        {
            Movie? movie = await _databaseContext.Movies.Where(m => m.Id == movieid).FirstOrDefaultAsync();

            if (movie == null)
            {
                return null;
            }
            return movie;
        }

        public async Task<Movie?> UpdateMovie(int movieid, string title, string rating, string description, int runtimeMins)
        {
            Movie? movie = await GetAMovie(movieid);
            if (movie == null)
            {
                return null;
            }
            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtimeMins;
            movie.UpdatedAt = DateTime.UtcNow;
            await _databaseContext.SaveChangesAsync();

            return movie;
        }

        public async Task<Movie?> DeleteMovie(int movieid){
            Movie? movie = await GetAMovie(movieid);
            if (movie == null)
            {
                return null;
            }
            _databaseContext.Remove(movie);
            await _databaseContext.SaveChangesAsync();

            return movie;
        }
    }
}
