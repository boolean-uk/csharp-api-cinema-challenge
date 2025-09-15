using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetAllCustomers();
        public Task<Customer?> CreateACustomer(string Name, string Email, int Phone);

        public Task<Customer?> UpdateCustomer(int Customerid, string Name, string Email, int Phone);

        public Task<Customer?> GetCustomerById(int Customerid);

        public Task<Customer?> DeleteCustomer(int Customerid);

    }
}
