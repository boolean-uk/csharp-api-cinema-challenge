using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;
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

        public async Task<Movie> CreateMovie(CreateMovieDto movieDto)
        {
            Movie movie = new Movie();
            movie.Title = movieDto.title;
            movie.Rating = movieDto.rating;
            movie.RuntimeMins = movieDto.runtimeMins;
            movie.Description = movieDto.description;
            movie.CreatedAt = DateTime.UtcNow;
            movie.CreatedAt = DateTime.UtcNow;

            if(movieDto.Screenings!= null)
            {
                foreach(var s in movieDto.Screenings)
                {
                    Screening screening = new Screening();
                    screening.ScreenNumber = s.screenNumber;
                    screening.Capacity = s.capacity;
                    screening.StartsAt = s.startsAt;
                    screening.CreatedAt = DateTime.UtcNow;
                    screening.UpdatedAt = DateTime.UtcNow;
                    movie.Screenings.Add(screening);
                }   
            }

            await _db.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie movieToBeDeleted = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if(movieToBeDeleted == null)
            {
                return null;
            }
            _db.Remove(movieToBeDeleted);
            await _db.SaveChangesAsync();
            return movieToBeDeleted;
        }

        public async Task<ICollection<Movie>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> UpdateMovie(int id, CreateMovieDto movieDto)
        {
            Movie movieToBeUpdated = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if(movieToBeUpdated == null)
            {
                return null;
            }
            movieToBeUpdated.Title = movieDto.title;
            movieToBeUpdated.Rating = movieDto.rating;
            movieToBeUpdated.RuntimeMins = movieDto.runtimeMins;
            movieToBeUpdated.Description = movieDto.description;
            movieToBeUpdated.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return movieToBeUpdated;
        }
    }
}
