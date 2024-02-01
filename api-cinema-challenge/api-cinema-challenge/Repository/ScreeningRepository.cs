using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _databaseContext;

        public ScreeningRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Screening?> CreateAScreeningForMovieId(Screening screening, int MovieId)
        {
            DateTime now = DateTime.UtcNow;
            screening.CreatedAt = now;
            screening.UpdatedAt = now;
            screening.MovieId = MovieId;

            _databaseContext.Screenings.Add(screening);
            SaveChanges();
            return (screening);
        }

        public async Task<List<Screening>> GetAllScreeningsByMovieId(int MovieId)
        {
            return await _databaseContext.Screenings.Where(s => s.MovieId == MovieId).ToListAsync();
        }

        private bool SaveChanges()
        {
            _databaseContext.SaveChanges();
            return true;
        }
    }
}
