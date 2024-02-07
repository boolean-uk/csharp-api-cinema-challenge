using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class SeatRepository : ISeatRepository
    {
        private readonly CinemaContext _context;

        public SeatRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Seat>> GetAllSeats()
        {
            return await _context.Seats.ToListAsync();
        }

        public async Task<Seat> GetSeat(int id)
        {
            return await _context.Seats.FindAsync(id);
        }

        public async Task<Seat> CreateSeat(Seat seat)
        {
            _context.Seats.Add(seat);
            await _context.SaveChangesAsync();

            return seat;
        }

        public async Task<Seat> UpdateSeat(int id , Seat seat)
        {
            var existingSeat = await _context.Seats.FindAsync(id);
            if(existingSeat == null)
            {
                throw new ArgumentNullException(nameof(existingSeat) , "Seat cannot be null.");
            }

            existingSeat.SeatNumber = seat.SeatNumber;
            existingSeat.RowNumber = seat.RowNumber;
            existingSeat.ScreenId = seat.ScreenId;

            await _context.SaveChangesAsync();

            return existingSeat;
        }

        public async Task<Seat> DeleteSeat(int id)
        {
            var seat = await _context.Seats.FindAsync(id);
            if(seat == null)
            {
                return null;
            }

            _context.Seats.Remove(seat);
            await _context.SaveChangesAsync();

            return seat;
        }
    }

}
