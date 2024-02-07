using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreenRepository : IScreenRepository
    {
        private CinemaContext _databaseContext;
        public ScreenRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Screen> CreateAScreen(Screen screen)
        {

            _databaseContext.Screens.Add(screen);
            SaveChanges();
            return screen;
        }

        private void SaveChanges()
        {
            _databaseContext.SaveChanges();
        }

        public async Task<Screen?> DeleteAScreen(int id)
        {
            Screen? screenToDelete = await GetScreenById(id);
            if (screenToDelete == null) { return null; }
            _databaseContext?.Screens.Remove(screenToDelete);
            SaveChanges();
            return screenToDelete;
        }

        public async Task<List<Screen>> GetAll()
        {
            List<Screen> response = await _databaseContext.Screens
                    .Include(s => s.Screenings).ThenInclude(s => s.Movie).Include(s => s.Seats)
                    .ToListAsync();
            return response;
        }

        public async Task<Screen?> UpdateAScreen(int id, string name)
        {
            Screen? screen = await GetScreenById(id)
                ;
            if (screen == null) { return null; }
            screen.name = name;
            screen.UpdatedAt = DateTime.UtcNow;
            SaveChanges();
            return screen;

        }
        public async Task<Screen?> GetScreenById(int id)
        {
            Screen? response = await _databaseContext.Screens
                .Include(s => s.Screenings).ThenInclude(s => s.Movie)
                .Include(s => s.Seats)
                .FirstOrDefaultAsync(c => c.id == id);
            if (response == null) { return null; }
            return response;
        }


    }
}
