using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{


    public class BookingRepository : IBookingRepository
    {
        private CinemaContext _databaseContext;

        public BookingRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<List<Booking>> GetAll()
        {
            return await _databaseContext.Bookings
                .Include(b => b.tickets).ThenInclude(t => t.screening).ThenInclude(s => s.Movie)
                .Include(b => b.tickets).ThenInclude(t => t.seat).ThenInclude(s => s.Screen)
                .ToListAsync();
        }

        public async Task<Booking?> GetBookingById(int id)
        {
            return await _databaseContext.Bookings.Where(b => b.Id == id)
                .Include(b => b.tickets).ThenInclude(t => t.screening).ThenInclude(s => s.Movie)
                .Include(b => b.tickets).ThenInclude(t => t.seat).ThenInclude(s => s.Screen)
                .FirstOrDefaultAsync();
                
        }

        public async Task<Booking> CreateABooking(Booking booking, List<int> ticketIds)
        {
            _databaseContext.Bookings.Add(booking);
            
            await SaveChangesAsync();
            foreach(var ticketId in ticketIds) {
                Ticket t = await _databaseContext.Tickets.Where(ticket => ticket.Id == ticketId).FirstAsync();
                t.bookingId = booking.Id;
            }
            
            return booking;
        }


        public async Task<Booking?> DeleteABooking(int bookingId)
        {
            var bookingToDelete = await GetBookingById(bookingId);
            if (bookingToDelete == null)
            {
                return null;
            }

            List<Ticket> Tickets = await _databaseContext.Tickets.Where(ticket => ticket.bookingId == bookingId).ToListAsync();
            foreach (Ticket t in Tickets)
            {
                
                t.bookingId = null;
            }



            _databaseContext.Bookings.Remove(bookingToDelete);
            await SaveChangesAsync();
            return bookingToDelete;
        }

        private async Task SaveChangesAsync()
        {
            await _databaseContext.SaveChangesAsync();
        }

        public Task<List<Ticket>> GetAvailableTicketsForScreening(int screeningId)
        {
            return _databaseContext.Tickets.Where(t => t.bookingId == null && t.screeningId == screeningId).ToListAsync();
        }
    }
}