using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories;

public class ScreeningRepository(CinemaContext db) : IRepository<Screening>
{
    public async Task<List<Screening>> GetAll()
    {
        return await db.Screenings
            .Include(s => s.Movie)
            .ToListAsync();
    }

    public Task<Screening> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Screening> Add(Screening entity)
    {
        throw new NotImplementedException();
    }

    public Task<Screening> Update(Screening entity)
    {
        throw new NotImplementedException();
    }

    public Task<Screening> Delete(Screening entity)
    {
        throw new NotImplementedException();
    }
}