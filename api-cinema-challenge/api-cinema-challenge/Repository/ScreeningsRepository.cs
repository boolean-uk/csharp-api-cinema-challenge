using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace api_cinema_challenge.Repository
{
    public class ScreeningsRepository : IScreeningsRepository
    {
        private CinemaContext _db;
        public ScreeningsRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Screenings?> CreateScreening(int ScreenNr, int Capacity, DateTime StartsAt, int MoviesId)
        {
            //Create screening to return
            Screenings screening = new Screenings();
            //Populate the screening with payload data
            screening.ScreenNr = ScreenNr;
            screening.Capacity = Capacity;
            screening.StartsAt = StartsAt;
            screening.MoviesId = MoviesId;
            //add screening to database and save it + return
            _db.Screenings.Add(screening);
            _db.SaveChanges();
            return screening;
        }

        public async Task<IEnumerable<Screenings>> GetScreenings()
        {
            return await _db.Screenings.ToListAsync();
        }
    }
}
