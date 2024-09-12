using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Screening> AddScreening(int screenNumber, int capacity, DateTime startsAt)
        {
            var screen = new Screening() { Id = _db.Screens.Count(), ScreenNumber = screenNumber, StartsAt = startsAt, Capacity = capacity, Created = DateTime.Now, Updated = DateTime.Now };
            await _db.Screens.AddAsync(screen);
            await _db.SaveChangesAsync();
            return screen;
        }

        public async Task<IEnumerable<Screening>> GetScreening()
        {
            return await _db.Screens.ToListAsync();
        }
    }
}
