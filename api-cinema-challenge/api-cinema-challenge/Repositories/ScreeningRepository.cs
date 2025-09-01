using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        private readonly CinemaContext _ctx;
        public ScreeningRepository(CinemaContext ctx) => _ctx = ctx;

        public async Task<Screening> AddForMovieAsync(int movieId, Screening s)
        {
            if (s.StartsAt.Kind != DateTimeKind.Utc)
                s.StartsAt = DateTime.SpecifyKind(s.StartsAt, DateTimeKind.Utc);

            s.MovieId = movieId;
            _ctx.Screenings.Add(s);
            await _ctx.SaveChangesAsync();
            return s;
        }

        public Task<List<Screening>> GetForMovieAsync(int movieId)
            => _ctx.Screenings.AsNoTracking()
                .Where(x => x.MovieId == movieId)
                .OrderBy(x => x.StartsAt)
                .ToListAsync();
    }
}
