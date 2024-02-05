using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories.customer
{
    public class BookingRepo : IBookingRepository
    {
        CinemaContext _db;
        public BookingRepo(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Booking?> Add(int customerId, int screeningId, int ticketQuantity)
        {
            var screening = await _db.Screenings.FirstOrDefaultAsync(s => s.Id.Equals(screeningId));
            if (screening == null) { return null; }
            if (screening.RemaningCapacity - ticketQuantity < 0) { throw new InvalidOperationException($"There are only {screening.RemaningCapacity} seats left"); }

            var booking = _db.Bookings.Add(new Booking { CustomerId = customerId, ScreeningId = screeningId, ticketQuantity = ticketQuantity });
            if (booking == null) { return null; }
            screening.RemaningCapacity -= ticketQuantity;
            await _db.SaveChangesAsync();
            return booking.Entity;
        }

        public async Task<List<Booking>> GetAll()
        {
            return await _db.Bookings.ToListAsync();
        }

        public async Task<List<Booking>> GetAllByCustomer(int customerId)
        {
            return await _db.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Screening)
                .ThenInclude(s => s.Movie)
                .Where(b => b.CustomerId.Equals(customerId))
                .ToListAsync();
        }

        public async Task<Booking?> Delete(int id)
        {
            var booking = await _db.Bookings.FirstOrDefaultAsync(b => b.Id.Equals(id));
            if (booking == null) { return null; }

            _db.Bookings.Remove(booking);
            await _db.SaveChangesAsync();
            return booking;
        }
    }
}
