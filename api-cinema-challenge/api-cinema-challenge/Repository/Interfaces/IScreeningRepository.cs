using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface IScreeningRepository
    {
        Task<IEnumerable<Screening>> GetAllScreenings(int movieId);
        Task<Screening> CreateScreening(int movieId , int screenNumber , int capacity , DateTime startsAt);
    }
}
