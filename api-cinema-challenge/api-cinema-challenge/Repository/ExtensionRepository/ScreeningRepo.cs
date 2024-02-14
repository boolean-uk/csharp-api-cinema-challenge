using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Repository.ExtensionRepository
{
    public class ScreeningRepo : Repository<Screening>
    {
        private readonly DataContext _db;

        public ScreeningRepo(DataContext db) : base(db)
        {
            _db = db;
        }

        public async override Task<IEnumerable<Screening>> Get()
        {
            return await _db.Screenings
                            .Include(s => s.Movie)
                            .Include(s => s.Tickets)
                            .ToListAsync();
        }

        public async override Task<Screening> GetById(object id)
        {
            return await _db.Screenings
                            .Include(s => s.Movie)
                            .Include(s => s.Tickets)
                            .FirstOrDefaultAsync(s => s.Id == (int)id);
        }

    }
}
