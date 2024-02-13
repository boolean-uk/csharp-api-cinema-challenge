using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;

namespace api_cinema_challenge.Repository.Specific
{
    public interface IScreeningRepository : IRepository<Screening>
    {
        public Task<IEnumerable<Screening>> GetAllByMovieId(int movieId);
    }
}
