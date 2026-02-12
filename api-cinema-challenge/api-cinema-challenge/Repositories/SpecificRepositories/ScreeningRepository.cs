using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories.SpecificRepositories
{
    public class ScreeningRepository : Repository<Screening>, IScreeningRepository
    {
        private readonly CinemaContext _context;

        public ScreeningRepository(CinemaContext dbContext) : base(dbContext)
        {

            _context = dbContext;
        }

        public async Task<IEnumerable<Screening>> GetScreeningsByMovieAsync(int movieId)
        {
            return await _context.Set<Screening>()
                .Where(s => s.MovieId == movieId)
                .Include(s => s.Movie)
                .ToListAsync();
        }
    }
}
