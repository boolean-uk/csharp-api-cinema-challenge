using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening> CreateScreening(Screening screening)
        {
            var exists = await _db.Screenings
                .Where(s => s.Id == screening.Id)
                .AnyAsync();

            if (exists) return null;

            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();

            return screening;
        }

        public async Task<IEnumerable<Screening>> GetByIdAsync(int movieId)
        {
            bool exists = await _db.Screenings
                .Where(s => s.MovieId == movieId)
                .AnyAsync();

            if (!exists)
                return null;

            var screenings = await _db.Screenings
                .Where(s => s.MovieId == movieId)
                .ToListAsync();

            return screenings;
        }
    }
}
