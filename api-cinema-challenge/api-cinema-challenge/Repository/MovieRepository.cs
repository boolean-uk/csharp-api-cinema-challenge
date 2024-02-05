using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
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

        public async Task<List<Movie>> GetAll()
        {
            return await _databaseContext.Movies.Include(m => m.Screenings).ThenInclude(s => s.Screen).ToListAsync();
        }

        public async Task<Movie?> GetMovieById(int id)
        {
            return await _databaseContext.Movies.Include(m => m.Screenings).ThenInclude(s => s.Screen).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movie> CreateAMovie(Movie movie)
        {
            _databaseContext.Movies.Add(movie);
            await SaveChangesAsync();
            return movie;
        }

        public async Task<Movie?> UpdateAMovie(int id, string title, string description, string rating, string director, DateTime Runtime, DateTime ReleaseDate)
        {
            var movieToUpdate = await GetMovieById(id);
            if (movieToUpdate == null)
            {
                return null;
            }

            movieToUpdate.Title = title;
            movieToUpdate.Description = description;
            movieToUpdate.Rating = rating;
            movieToUpdate.Director = director;
            movieToUpdate.Runtime = Runtime;
            movieToUpdate.ReleaseDate = ReleaseDate;
            movieToUpdate.UpdatedAt = DateTime.UtcNow;

            await SaveChangesAsync();
            return movieToUpdate;
        }

        public async Task<Movie?> DeleteAMovie(int id)
        {
            var movieToDelete = await GetMovieById(id);
            if (movieToDelete == null)
            {
                return null;
            }

            _databaseContext.Movies.Remove(movieToDelete);
            await SaveChangesAsync();
            return movieToDelete;
        }

        private async Task SaveChangesAsync()
        {
            await _databaseContext.SaveChangesAsync();
        }
    }
}