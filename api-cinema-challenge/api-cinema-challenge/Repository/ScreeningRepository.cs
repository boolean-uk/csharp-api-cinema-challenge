using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreening<Screening>
    {
        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Screening> CreateEntity(Screening entity)
        {
            await _db.Screenings.AddAsync(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public Task<List<Screening>> GetAllEntities()
        {
            throw new NotImplementedException();
        }
    }
}
