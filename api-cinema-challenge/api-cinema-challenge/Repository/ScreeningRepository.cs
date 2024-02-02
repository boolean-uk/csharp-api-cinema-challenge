using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using System.Numerics;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _databaseContext;
        public ScreeningRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<List<Screening?>> GetScreenings(int movieId)
        {
            var movie = await _databaseContext.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(t => t.Id == movieId);
            return movie.Screenings;
        }

        public async Task<Screening?> CreateScreening(int screenNumber, int capacity, DateTime startsAt, int movieId)
        {
            List<Screening> screenings = _databaseContext.Screenings.ToList();
            int nrScreenings = await _databaseContext.Screenings.CountAsync();
            int id = screenings.Last().Id;
            id++;

            for (int i = 0; i < nrScreenings; i++)
            {
                if (screenings[i].ScreenNumber == screenNumber)
                    return null;
            }

            Screening newScreening = new Screening() { Id = id, ScreenNumber = screenNumber, Capacity = capacity, StartsAt = startsAt, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = movieId};
            await _databaseContext.AddAsync(newScreening);
            await _databaseContext.SaveChangesAsync();
            return newScreening;
        }
    }
}
