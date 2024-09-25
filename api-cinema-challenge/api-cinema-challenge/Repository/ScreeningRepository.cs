using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreening
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Screening> Create(Screening entity)
        {
            await _db.Screenings.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Screening>> GetAll(int movieId)
        {
            var entity = await _db.Screenings.Where(x => x.Movieid == movieId).ToListAsync();
            
            return entity;
        }

    }
}
