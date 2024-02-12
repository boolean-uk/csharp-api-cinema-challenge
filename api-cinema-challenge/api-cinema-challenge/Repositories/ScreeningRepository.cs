using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _dbContext;

        public ScreeningRepository(CinemaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Screening> CreateScreening(int id, Screening screening)
        {
            var movie = await _dbContext.Movies.FirstAsync(x => x.Id == id);

            Screening aScreening = new Screening() 
            { 
                Id = screening.Id,
                Capacity = screening.Capacity,
                Movie = movie,
                ScreenNumber = screening.ScreenNumber,
                startsAt = screening.startsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            movie.Screenings.Add(aScreening);

            _dbContext.Screenings.Add(aScreening);
            _dbContext.SaveChangesAsync();

            return aScreening;
        }

        public async Task<IEnumerable<Screening>> GetScreenings()
        {
            return await _dbContext.Screenings.ToListAsync();
            
        }
    }
}
