using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {

        Task<Screening> CreateScreening(Screening request, int movieId);

        Task<ICollection<Screening>> GetScreenings(int movieId);
    }
}
