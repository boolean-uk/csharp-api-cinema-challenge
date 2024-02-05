using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening> AddScreening(Screening screening)
        {
            await _db.Screenings.AddAsync(screening);
            _db.SaveChanges();
            return screening;
        }

        public async Task<IEnumerable<Screening>> GetAllScreenings()
        {
            return await _db.Screenings.Include(screening => screening.Movie).ToListAsync();
        }
    }
}
