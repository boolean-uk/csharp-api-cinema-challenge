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

        public async Task<Screening?> AddScreening(int id, Screening screening)
        {
            var movie = _db.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return null;
            }

            screening.Movie = movie;
            screening.MovieId = movie.Id;
            movie.Screenings.Add(screening);

            await _db.Screenings.AddAsync(screening);
            _db.SaveChanges();
            return screening;
        }

        public async Task<IEnumerable<Screening>?> GetAllScreenings(int id)
        {
            var movie = await _db.Movies.Include(movie => movie.Screenings)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return null;
            }

            return movie.Screenings;
        }
    }
}
