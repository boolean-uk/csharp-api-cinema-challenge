using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories.customer
{
    public interface IBookingRepository
    {
        public Task<Booking?> Add(int customerId, int screeningId, int ticketQuantity);
        public Task<List<Booking>> GetAll();
        public Task<List<Booking>> GetAllByCustomer(int customerId);
        public Task<Booking?> Delete(int id);
    }
}
