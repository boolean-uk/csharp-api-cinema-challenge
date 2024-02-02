using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer?> CreateCustomer(string Name, string Email, string PhoneNr, int ScreeningId);
        Task<Customer?> GetCustomer(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer?> UpdateCustomer(int id, string Name, string Email, string? PhoneNr, int? ScreeningId);
        Task<Customer?> DeleteCustomer(int id);
    }
}
