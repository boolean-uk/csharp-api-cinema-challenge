using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Repository {

    public class TicketRepository : ITicketRepository
    {
        public Task<Ticket> CreateTicket(int movieId, int screeningId, int customerId, int numSeats)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetTicketsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetTicketsByScreeningId(int screeningId)
        {
            throw new NotImplementedException();
        }
    }
}