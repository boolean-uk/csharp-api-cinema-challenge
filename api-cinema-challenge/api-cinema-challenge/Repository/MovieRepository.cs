using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Payload;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IRepository<Movie, MoviePayload>
    {
        private CinemaContext _db;
        public MovieRepository(CinemaContext context)
        {
            _db = context;
        }
        public async Task<Movie> Create(MoviePayload entity)
        {
            Movie movie = new Movie()
            {
                Title = entity.Title,
                RuntimeMins = entity.RuntimeMins,
                Description = entity.Description,
                Rating = entity.Rating,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };
            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();

            if (entity.Screenings != null)
            {
                foreach (ScreeningPayload sp in entity.Screenings)
                {
                    Screening screening = new Screening()
                    {
                        Capacity = sp.Capacity,
                        StartsAt = sp.StartsAt,
                        ScreenNumber = sp.ScreenNumber,
                        CreatedAT = DateTime.UtcNow,
                        UpdatedAT = DateTime.UtcNow,
                        
                        MovieId = movie.Id
                    };
                    await _db.AddAsync(screening);
                    await _db.SaveChangesAsync();
                }
            }
            return movie;
        }

        public async Task<Movie> Delete(int id)
        {
            Movie movie = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return null;
            }
            _db.Remove(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> Update(MoviePayload entity, int id)
        {
            Movie movie = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if(movie == null)
            {
                return null;
            }
            movie.Title = entity.Title;
            movie.Description = entity.Description;
            movie.RuntimeMins = entity.RuntimeMins;
            movie.Rating = entity.Rating;
            movie.UpdatedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();
            return movie;
        }
    }
}
