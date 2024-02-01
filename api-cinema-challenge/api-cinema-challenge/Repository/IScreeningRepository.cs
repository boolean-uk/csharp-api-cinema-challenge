using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IScreeningRepository
    {
        
        Task<List<Screening>> GetAllScreeningsByMovieId(int id);
        Task<Screening?> CreateAScreeningForMovieId(Screening screening, int MovieId);

    }
}
