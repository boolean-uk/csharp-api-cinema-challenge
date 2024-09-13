using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Task<ICollection<Screening>> GetScreenings(int movieId);
        Task<Screening> CreateScreening(int id, CreateScreeningDto screenDto);
    }
}
