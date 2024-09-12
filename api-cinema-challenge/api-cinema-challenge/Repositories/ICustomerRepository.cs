using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;

namespace api_cinema_challenge.Repositories
{
    public interface ICustomerRepository
    {
        Task<ICollection<Customer>> GetCustomers();
        Task<Customer> CreateCustomer(CreateCustomerDto customerDto);
        Task<Customer> UpdateCustomer(int id, CreateCustomerDto customerDto);
        Task<Customer> DeleteCustomer(int id);
    }
}
