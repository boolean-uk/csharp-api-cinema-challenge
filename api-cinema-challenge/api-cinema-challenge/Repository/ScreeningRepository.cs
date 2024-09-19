using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _context;
        public ScreeningRepository(CinemaContext db)
        {
            _context = db;
        }
        public async Task<Screening> AddAsync(Screening entity)
        {
            _context.Screenings.Attach(entity).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            return await _context.Screenings.Where(x =>  x.Id == id).ToListAsync();
        }
    }
}
