using api_cinema_challenge.Data;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository.Specific
{
    public class ScreeningRepository : Repository<Screening>, IScreeningRepository
    {
        public ScreeningRepository(DatabaseContext databaseContext) : base(databaseContext)
        {}
        
        public async Task<IEnumerable<Screening>> GetAllByMovieId(int movieId)
        {
            return await Table.Include(s => s.ScreeningSeats).ThenInclude(ss => ss.Seat).Where(s => s.MovieId == movieId).ToListAsync();
        }
    }
}
