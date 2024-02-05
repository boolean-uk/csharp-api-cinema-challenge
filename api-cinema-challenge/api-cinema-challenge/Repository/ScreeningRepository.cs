using api_cinema_challenge.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Repository;
namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _databaseContext;
        public ScreeningRepository(CinemaContext db)
        {
            _databaseContext = db;
        }
        public async Task<IEnumerable<Screening>> GetAllScreenings(){
            return await _databaseContext.Screenings
            .Include(s => s.Movie)
            .ToListAsync();
        }

        public async Task<Screening?> CreateScreening(int movie_id, int screen_number, int capacity, DateTime startsAt)
        {
            Screening screening = new Screening(){
                MovieId = movie_id, 
                screenNumber = screen_number, 
                Capacity = capacity, 
                StartsAt = startsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            
            _databaseContext.Screenings.Add(screening);
            await _databaseContext.SaveChangesAsync();
            return screening;
        }

        public async Task<Screening?> GetScreeningById(int id)
        {
            Screening? screening = await _databaseContext.Screenings.Where(s => s.Id == id).FirstOrDefaultAsync();
            return screening;
        }
    }

}
