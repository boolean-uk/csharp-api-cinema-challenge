using api_cinema_challenge.Data;
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository {

    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db) {
            _db = db;
        }

        public async Task<Screening> CreateScreening(int screenNumber, int movieId, int capacity, DateTime startsAt, DateTime endsAt, List<CreateSeatPayload> seats)
        {
            var movie = _db.Movies.Where(movie => movie.Id == movieId);
            if(movie == null)
                return null;
            
            Screening screening = new Screening()
            {
                ScreenNumber = screenNumber,
                Capacity = capacity,
                StartsAt = startsAt,
                EndsAt = endsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MovieId = movieId

            };

            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();

            foreach (CreateSeatPayload seat in seats)
            {
                Seat r = new Seat()
                {
                    SeatRow = seat.SeatRow,
                    SeatNumber = seat.SeatNumber,
                    ScreeningId = screening.Id
                };
                await _db.Seats.AddRangeAsync(r);
            }

            await _db.SaveChangesAsync();

            return screening;
        }

        public Task DeleteScreening(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Screening>> GetAllScreenings()
        {
            throw new NotImplementedException();
        }

        public async Task<Screening?> GetScreening(int id)
        {
            if(id <= 0)
                return null;
            
            var screening = await _db.Screenings
                        .Include(movie => movie.Movie)
                        .Where(screening => screening.Id == id)
                        .FirstOrDefaultAsync();
            if(screening == null)
                return null;
            return screening;
        }

        public Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateScreening(int id, Screening screening)
        {
            throw new NotImplementedException();
        }
    }
}