using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        CinemaContext _cinemaContext;
        public ScreeningRepository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Screening> CreateScreening(int movieID, int screenNumber, int capacity, DateTime startsAt)
        {
            Screening screening = new Screening();
            screening.ScreenNumber = screenNumber;
            screening.MovieId = movieID;
            screening.Capacity = capacity;
            screening.UpdatedAt = DateTime.Now.ToUniversalTime();
            screening.CreatedAt = DateTime.Now.ToUniversalTime();
            screening.StartsAt = startsAt;
            await _cinemaContext.Screenings.AddAsync(screening);
            _cinemaContext.SaveChanges();
            return screening;
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int movieId)
        {
            return await _cinemaContext.Screenings.Where(s => s.MovieId == movieId).ToListAsync(); ;
        }
    }
}
