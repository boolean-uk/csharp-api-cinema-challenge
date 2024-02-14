using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Repository.ExtensionRepository
{
    public class PrescriptionRepo : Repository<Customer>
    {
        private readonly DataContext _db;

        public PrescriptionRepo(DataContext db) : base(db)
        {
            _db = db;
        }

        public async override Task<IEnumerable<Customer>> Get()
        {
            return await _db.Customers
                                 .Include(c => c.Tickets)
                                     .ThenInclude(t => t.Screening)
                                         .ThenInclude(s => s.Movie)
                                 .ToListAsync();
        }

        public async override Task<Customer> GetById(object id)
        {
            return await _db.Customers
                                 .Include(c => c.Tickets)
                                     .ThenInclude(t => t.Screening)
                                         .ThenInclude(s => s.Movie)
                                 .FirstOrDefaultAsync(c => c.Id == (int)id);
        }
    }
}