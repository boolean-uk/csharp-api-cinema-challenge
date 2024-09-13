using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository(CinemaContext db) : IRepository<Screening>
    {
        public async Task<Screening> Add(Screening entity)
        {
            await db.Screenings.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }
  

        public async Task<List<Screening>> GetAll()
        {
            return await db.Screenings.ToListAsync();
        }


        public async Task<Screening> GetById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<Screening>> GetAllById(int id)
        {
            return await db.Screenings.Where(s => s.MovieId == id).ToListAsync();

        }

        public async Task<Screening> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Screening> Update(Screening screening)
        {
            throw new NotImplementedException();
        }

       
    }
}
