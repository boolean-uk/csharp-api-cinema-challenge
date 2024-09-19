using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Customer entity);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> UpdateAsync(Customer entity);
        Task<Customer> DeleteAsync(int id);
        Task<Ticket> BookTickets(Ticket entity);
        Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningId);
    }
}
