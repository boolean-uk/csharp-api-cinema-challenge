using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreenRepository : IScreenRepository
    {
        private readonly CinemaContext _context;

        public ScreenRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Screen>> GetAllScreens()
        {
            return await _context.Screens.ToListAsync();
        }

        public async Task<Screen> GetScreen(int id)
        {
            return await _context.Screens.FindAsync(id);
        }

        public async Task<Screen> CreateScreen(Screen screen)
        {
            _context.Screens.Add(screen);
            await _context.SaveChangesAsync();

            return screen;
        }

        public async Task<Screen> UpdateScreen(int id , Screen screen)
        {
            var existingScreen = await _context.Screens.FindAsync(id);
            if(existingScreen == null)
            {
                throw new ArgumentNullException(nameof(screen) , "Screen cannot be null.");
            }

            existingScreen.ScreenNumber = screen.ScreenNumber;

            await _context.SaveChangesAsync();

            return existingScreen;
        }

        public async Task<Screen> DeleteScreen(int id)
        {
            var screen = await _context.Screens.FindAsync(id);
            if(screen == null)
            {
                return null;
            }

            _context.Screens.Remove(screen);
            await _context.SaveChangesAsync();

            return screen;
        }
    }
}
