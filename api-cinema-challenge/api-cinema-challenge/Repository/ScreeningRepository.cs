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
        public async Task<Screening> CreateScreening(Screening request, int movieId)
        {
            Movie movie = await _db.Movies.Where(x => x.Id == movieId).FirstOrDefaultAsync()
                ?? throw new ArgumentException("Movie with given id does not exist");

            Screening screening = new Screening()
            {
                ScreenNumber = request.ScreenNumber,
                StartsAt = request.StartsAt,
                Capacity = request.Capacity,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime(),
                MovieId = request.MovieId
            };
           
            movie.Screenings.Add(screening);
            _db.screenings.Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<ICollection<Screening>> GetScreenings(int movieId)
        {
          //  MovieRepository m = new MovieRepository(_db);
          //  Movie movie = await m.GetMovieById(movieId);
            return await _db.Movies.Where(x => x.Id == movieId).SelectMany(s => s.Screenings).ToListAsync();
        }
    }
}
