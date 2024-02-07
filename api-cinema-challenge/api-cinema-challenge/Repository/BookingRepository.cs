using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly CinemaContext _context;

        public BookingRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<Booking> GetBooking(int id)
        {
            return await _context.Bookings.FindAsync(id);
        }

        public async Task<Booking> CreateBooking(Booking booking)
        {

            if(booking == null)
            {
                throw new ArgumentNullException(nameof(booking) , "Booking cannot be null.");
            }

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return booking;
        }

        public async Task<Booking> DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if(booking == null)
            {
                return null;
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            return booking;
        }
    }
}
