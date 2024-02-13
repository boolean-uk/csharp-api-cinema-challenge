using api_cinema_challenge.Models.DatabaseModels;

namespace api_cinema_challenge.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<Customer> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer, int id);
        Task<Customer> DeleteCustomer(int id);
        Task<Ticket> BookTicket(Ticket ticket);
        Task<IEnumerable<Ticket>> GetTickets();
    }
}
