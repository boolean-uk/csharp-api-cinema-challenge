using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models.PatientModels;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Repository.ExtensionRepository
{
    public class TicketRepo : Repository<Ticket>
    {
        private readonly DataContext _db;

        public TicketRepo(DataContext db) : base(db)
        {
            _db = db;
        }

        public async override Task<IEnumerable<Ticket>> Get()
        {
            return await _db.Tickets
                            .Include(t => t.Customer)
                            .Include(t => t.Screening)
                                .ThenInclude(s => s.Movie)
                            .ToListAsync();
        }

        public async override Task<Ticket> GetById(object customerId, object screeningId)
        {
            return await _db.Tickets
                            .Include(t => t.Customer)
                            .Include(t => t.Screening)
                                .ThenInclude(s => s.Movie)
                            .FirstOrDefaultAsync(t => t.CustomerId == (int)customerId && t.ScreeningId == (int)screeningId);
        }
    }
}
