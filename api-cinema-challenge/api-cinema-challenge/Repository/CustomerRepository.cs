using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Repository {

    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> CreateCustomer(string name, string email, string phone)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}