using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Payload;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IRepository<Screening, ScreeningPayload>
    {
        CinemaContext _db;

        public ScreeningRepository(CinemaContext context)
        {
            _db = context;
        }
        public Task<Screening> Create(ScreeningPayload entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Screening> CreateOnId(ScreeningPayload entity, int id)
        {
            Screening screening = new Screening()
            {
                Capacity = entity.Capacity,
                StartsAt = entity.StartsAt,
                ScreenNumber = entity.ScreenNumber,
                CreatedAT = DateTime.UtcNow,
                UpdatedAT = DateTime.UtcNow,
                MovieId = id
            };
            await _db.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public Task<Screening> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Screening>> GetAll()
        {
            return await _db.Screenings.ToListAsync();
        }

        public async Task<IEnumerable<Screening>> GetById(int id)
        {
            return await _db.Screenings.Where(s => s.MovieId == id).ToListAsync();
        }


        public Task<Screening> Update(ScreeningPayload entity, int id)
        { 
            throw new NotImplementedException();
        }
    }
}