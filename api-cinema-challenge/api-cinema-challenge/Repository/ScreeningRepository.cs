using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

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
            await _context.Screenings.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<IEnumerable<Screening>> GetScreenings()
        {
            throw new NotImplementedException();
        }
    }
}
