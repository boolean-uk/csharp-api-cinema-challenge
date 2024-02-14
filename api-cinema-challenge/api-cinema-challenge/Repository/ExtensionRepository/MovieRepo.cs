using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Repository.ExtensionRepository
{
    public class MovieRepo: Repository<Movie>
    {
        private readonly DataContext _db;

        public MovieRepo(DataContext db) : base(db)
        {
            _db = db;
        }

        public async override Task<IEnumerable<Movie>> Get()
        {
            return await _db.Movies
                            .Include(m => m.Screenings)
                            .ToListAsync();
        }

        public async override Task<Movie> GetById(object id)
        {
            return await _db.Movies
                            .Include(m => m.Screenings)
                            .FirstOrDefaultAsync(m => m.Id == (int)id);
        }
    }
}
