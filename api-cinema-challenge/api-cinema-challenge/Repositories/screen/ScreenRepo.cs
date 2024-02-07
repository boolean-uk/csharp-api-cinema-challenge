using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories.customer
{
    public class ScreenRepo : IScreenRepository
    {
        CinemaContext _db;
        public ScreenRepo(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screen?> Add(int capacity)
        {
            var newScreen = _db.Screens.Add(new Screen { Capacity = capacity });
            await _db.SaveChangesAsync();
            return newScreen.Entity;
        }

        public async Task<List<Screen>> GetAll()
        {
            return await _db.Screens.ToListAsync();
        }

        public async Task<Screen?> Remove(int screenId)
        {
            var screen = await _db.Screens.FirstOrDefaultAsync(s => s.Equals(screenId));
            if (screen == null) { return null; }
            _db.Screens.Remove(screen);
            await _db.SaveChangesAsync();
            return screen;
        }
    }
}
