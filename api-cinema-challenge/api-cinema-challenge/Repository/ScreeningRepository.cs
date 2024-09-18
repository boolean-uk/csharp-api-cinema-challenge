using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreening<Screening>
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Screening> CreateEntity(Screening entity)
        {
            await _db.Screenings.AddAsync(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<Screening> GetEntities(int id)
        {
            return await _db.Screenings.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<Screening>> GetAllEntities(int id)
        {
            var screenings = await _db.Screenings
                .Where(x => x.MovieId == id)
                .ToListAsync();

            return screenings;

        }
    }
}
