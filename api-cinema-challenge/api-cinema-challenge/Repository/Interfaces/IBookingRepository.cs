using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllBookings();
        Task<Booking> GetBooking(int id);
        Task<Booking> CreateBooking(Booking booking);
        Task<Booking> DeleteBooking(int id);
    }

}
