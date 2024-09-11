using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Ticket> AddTicket(int screeningId)
        {

            await _db.Ticket.AddAsync(new Ticket(s));
            await _db.SaveChangesAsync();
            return new Movie(title, rating, description, runtimeMins);
        }

        public async  Task<IEnumerable<Ticket>> GetTicket()
        {
            throw new NotImplementedException();
        }
    }
}
