using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IBookingRepository
    {

        public Task<Booking> CreateABooking(Booking booking, List<int> ticketIds);
        public Task<List<Ticket>> GetAvailableTicketsForScreening(int screeningId);
        public Task<Booking?> DeleteABooking(int id);
        public Task<List<Booking>> GetAll();
        
        public Task<Booking?> GetBookingById(int id);



    }
}

