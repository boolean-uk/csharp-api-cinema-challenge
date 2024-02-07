using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private readonly CinemaContext _context;

        public ScreeningRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Screening>> GetAllScreenings(int movieId)
        {
            return await _context.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
        }

        public async Task<Screening> CreateScreening(int movieId , int screenNumber , int capacity , DateTime startsAt)
        {
            var screening = new Screening
            {
                ScreenNumber = screenNumber ,
                Capacity = capacity ,
                StartsAt = startsAt ,
                MovieId = movieId
            };

            _context.Screenings.Add(screening);
            await _context.SaveChangesAsync();

            return screening;
        }
    }
}
