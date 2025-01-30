using System.Net.Sockets;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.GenericRepositories;

namespace api_cinema_challenge.Repositories.SpecificRepositories
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<IEnumerable<Ticket>> GetTicketsByCustomerAsync(int customerId);
        Task<IEnumerable<Ticket>> GetTicketsByScreeningAsync(int screeningId);
    }
}
