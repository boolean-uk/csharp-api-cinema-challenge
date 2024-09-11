using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Screening> AddScreening(int screenNumber, int capacity, DateTime startsAt)
        {
            await _db.Screens.AddAsync(new Screening(screenNumber, capacity, startsAt));
            await _db.SaveChangesAsync();
            return new Screening(screenNumber, capacity, startsAt);
        }

        public async Task<IEnumerable<Screening>> GetScreening()
        {
            return await _db.Screens.ToListAsync();
        }
    }
}
