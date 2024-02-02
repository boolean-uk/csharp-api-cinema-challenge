using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        
        Task<List<Screening>> GetScreeningsByMovieId(int id);
        Task<List<Screening>> GetScreenings();
        Task<Screening?> CreateAScreeningForMovieId(Screening screening, int MovieId);

    }
}
