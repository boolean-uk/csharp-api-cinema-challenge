using api_cinema_challenge.Data;
using api_cinema_challenge.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _cc;

        public MovieRepository(CinemaContext cc)
        {
            _cc = cc;
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            await _cc.AddAsync(movie);
            await _cc.SaveChangesAsync();
            movie.CreatedAt = DateTime.Now;
            return movie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie movie = await GetMovieById(id);
            _cc.Remove(movie);
            await _cc.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _cc.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _cc.Movies.Include(m => m.Screenings).ToListAsync();
        }

        public async Task<Movie> UpdateMovie(Movie movie, int id)
        {
            Movie dbMovie = await GetMovieById(id);
            dbMovie.UpdatedAt = DateTime.Now;
            dbMovie = movie;
            await _cc.SaveChangesAsync();
            return await GetMovieById(id);
        }
    }
}
