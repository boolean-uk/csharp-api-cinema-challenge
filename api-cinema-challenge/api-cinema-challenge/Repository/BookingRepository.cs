using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;


public class BookingRepository : IBookingRepository
{
    private readonly CinemaContext _context;

    public BookingRepository(CinemaContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Booking>> GetAllAsync()
    {
        return await _context.Bookings
                             .Include(s => s.Movie)
                             .ToListAsync();
    }

    public async Task<Booking> CreateAsync(Booking bookings)
    {
        _context.Bookings.Add(bookings);
        await _context.SaveChangesAsync();
        return bookings;
    }
}
