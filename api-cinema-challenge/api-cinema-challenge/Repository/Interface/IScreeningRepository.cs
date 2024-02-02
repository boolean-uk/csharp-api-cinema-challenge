using api_cinema_challenge.Data.DTO;
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interface {

    public interface IScreeningRepository
    {
        Task<Screening> CreateScreening(int screenNumber, int movieId, int capacity, DateTime startsAt, DateTime endsAt, List<CreateSeatPayload> seats);
        Task<Screening?> GetScreening(int id);
        Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId);
        Task<IEnumerable<Screening>> GetAllScreenings();
        Task UpdateScreening(int id, Screening screening);
        Task DeleteScreening(int id);
    }

}
