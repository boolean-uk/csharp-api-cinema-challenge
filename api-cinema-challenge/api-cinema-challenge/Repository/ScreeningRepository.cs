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
            
            //Create tickets for new screening

             List<Seat> seatsInScreeningRoom = await _databaseContext.Seats.Where(S => S.ScreenId == screening.ScreenId).ToListAsync();
            List<Ticket> tickets = new List<Ticket>();    
            foreach(Seat seat in seatsInScreeningRoom)
                    { tickets.Add(new Ticket() { screeningId = screening.Id, seatId = seat.Id, price = 15f, createdAt=DateTime.UtcNow, updatedAt=DateTime.UtcNow }); }


            _databaseContext.Tickets.AddRange(tickets);

            SaveChanges();


            return (screening);
        }

        public async Task<List<Screening>> GetScreeningsByMovieId(int MovieId)
        {
            return await _databaseContext.Screenings
                .Include(s => s.Movie)
                .Include(s => s.Screen).ThenInclude(s => s.Seats)
                .Include(s => s.Tickets)
                .Where(s => s.MovieId == MovieId).ToListAsync();
        }
        public async Task<List<Screening>> GetScreenings()
        {
            return await _databaseContext.Screenings
                .Include(s => s.Movie)
                .Include(s => s.Tickets)
                .Include(s => s.Screen).ThenInclude(s => s.Seats)
                .ToListAsync();
        }
        private bool SaveChanges()
        {
            _databaseContext.SaveChanges();
            return true;
        }

        public async Task<Screening?> DeleteScreening(int ScreeningId)
        {
            
            Screening? screeningToDelete = _databaseContext.Screenings.FirstOrDefault(s => s.Id == ScreeningId);
            if (screeningToDelete == null) { return null; }
            _databaseContext.Screenings.Remove(screeningToDelete);
            SaveChanges();
            return screeningToDelete;

        }

    }
}
