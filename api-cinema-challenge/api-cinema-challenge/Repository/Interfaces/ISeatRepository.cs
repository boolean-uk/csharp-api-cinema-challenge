using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface ISeatRepository
    {
        Task<IEnumerable<Seat>> GetAllSeats();
        Task<Seat> GetSeat(int id);
        Task<Seat> CreateSeat(Seat seat);
        Task<Seat> UpdateSeat(int id , Seat seat);
        Task<Seat> DeleteSeat(int id);
    }
}
