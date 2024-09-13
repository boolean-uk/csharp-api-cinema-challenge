using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening> CreateScreening(int movieId, CreateScreeningDto screeningDto)
        {
            Movie movieScreened = await _db.Movies.FirstOrDefaultAsync(m => m.Id == movieId);
            if(movieScreened == null)
            {
                return null;
            }

            Screening screening = new Screening();
            screening.ScreenNumber = screeningDto.screenNumber;
            screening.Capacity = screeningDto.capacity;
            screening.StartsAt = screeningDto.startsAt;
            screening.CreatedAt = DateTime.UtcNow;
            screening.UpdatedAt = DateTime.UtcNow;

            await _db.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<ICollection<Screening>> GetScreenings(int movieId)
        {
            return await _db.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
        }
    } 
}
