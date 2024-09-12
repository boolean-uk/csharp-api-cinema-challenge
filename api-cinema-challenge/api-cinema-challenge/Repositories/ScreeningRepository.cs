using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public Task<Screening> CreateScreening()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Screening>> GetScreenings()
        {
            throw new NotImplementedException();
        }
    }
}
