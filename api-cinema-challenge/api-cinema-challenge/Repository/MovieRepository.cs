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
        public async Task<Movie> AddAsync(Movie entity)
        {
            //await _databaseContext.Movies.AddAsync(entity);
            _databaseContext.Movies.Attach(entity).State = EntityState.Added;
            await _databaseContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _databaseContext.Movies.ToListAsync();
        }

        public async Task<Movie> DeleteAsync(int id)
        {
            var removed = await GetMovieById(id);
            if (removed != null)
            {
                _databaseContext.Remove(removed);
                await _databaseContext.SaveChangesAsync();
                return removed;
            }
            else
            {
                return null;
            }
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _databaseContext.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Movie> UpdateAsync(Movie entity)
        {
            _databaseContext.Attach(entity).State = EntityState.Modified;
            await _databaseContext.SaveChangesAsync();
            return entity;
        }

        public async Task<string> GetTitleById(int id)
        {
            var movie = await _databaseContext.Movies.FirstOrDefaultAsync(x => x.Id == id);
            return movie.Title;
        }
    }
}
