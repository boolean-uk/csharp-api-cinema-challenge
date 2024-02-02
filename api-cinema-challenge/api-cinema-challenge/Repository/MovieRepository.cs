using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using System.Numerics;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _databaseContext;
        public MovieRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<List<Movie>> GetMovies()
        {
            var tasks = _databaseContext.Movies.ToListAsync();
            return await tasks;
        }

        public async Task<Movie?> GetMovie(int id)
        {
            var task = await _databaseContext.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(t => t.Id == id);
            return task;
        }

        public async Task<Movie?> CreateMovie(string title, string rating, string description, int runtimeMins, ScreeningPost? screening)
        {
            List<Movie> movies = _databaseContext.Movies.ToList();
            int nrMovies = await _databaseContext.Movies.CountAsync();
            int id = movies.Last().Id;
            id++;

            for (int i = 0; i < nrMovies; i++)
            {
                if (movies[i].Title == title)
                    return null;
            }

            var newMovie = new Movie() { Id = id, Title = title, Rating = rating, Description = description, RuntimeMins = runtimeMins, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() };
            newMovie.Screenings.Add(new Screening() { ScreenNumber = screening.ScreenNumber, Capacity = screening.Capacity, StartsAt = screening.StartsAt });
            
            await _databaseContext.AddAsync(newMovie);
            await _databaseContext.SaveChangesAsync();
            return newMovie;
        }

        public async Task<Movie>? UpdateMovie(Movie movie, string? title, string? rating, string? description, int? runtimeMins)
        {
            bool hasUpdate = false;
            List<Movie> movieList = _databaseContext.Movies.ToList();
            int nrMovies = await _databaseContext.Movies.CountAsync();

            if (title != null)
            {
                for (int i = 0; i < nrMovies; i++)
                {
                    if (movieList[i].Title == title)
                        return null;
                }

                movie.Title = title;
                hasUpdate = true;
            }

            if (rating != null)
            {
                movie.Rating = rating;
                hasUpdate = true;
            }

            if (description != null)
            {
                movie.Description = description;
                hasUpdate = true;
            }

            if (!hasUpdate) throw new Exception("No update data provided");

            movie.UpdatedAt = DateTime.Now.ToUniversalTime();
            await _databaseContext.SaveChangesAsync();
            return movie;
        }

        public async Task<List<Movie>> DeleteMovie(Movie movie)
        {
            _databaseContext.Movies.Remove(movie);
            await _databaseContext.SaveChangesAsync();
            return await _databaseContext.Movies.ToListAsync();
        }
    }
}
