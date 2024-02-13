using api_cinema_challenge.Data;
using api_cinema_challenge.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class ScreenRepository : IScreenRepository
    {
        private CinemaContext _cc;

        public ScreenRepository(CinemaContext cc)
        {
            _cc = cc;
        }

        public async Task<Screen> CreateScreen(Screen screen)
        {
            await _cc.AddAsync(screen);
            await _cc.SaveChangesAsync();
            screen.CreatedAt = DateTime.Now;
            return screen;
        }

        public async Task<Screen> DeleteScreen(int id)
        {
            Screen screen = await GetScreenById(id);
            _cc.Remove(screen);
            await _cc.SaveChangesAsync();
            return screen;

        }

        public async Task<Screen> GetScreenById(int id)
        {
            return await _cc.Screens.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Screen>> GetScreenings()
        {
            return await _cc.Screens.Include(s => s.Movie).Include(s => s.Customers).ToListAsync();
        }

        public async Task<Screen> UpdateScreen(Screen screen, int id)
        {
            Screen dbScreen = await GetScreenById(id);
            dbScreen.UpdatedAt = DateTime.Now;
            dbScreen = screen;
            await _cc.SaveChangesAsync();
            return await GetScreenById(id);
        }
    }
}
