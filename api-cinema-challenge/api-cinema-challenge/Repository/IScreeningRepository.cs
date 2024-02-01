using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        Task<List<Screening?>> GetScreenings(int id);
        Task<Screening?> CreateScreening(int screenNumber, int capacity, DateTime startsAt, int movieId);
    }
}