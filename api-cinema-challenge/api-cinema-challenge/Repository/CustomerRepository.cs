using api_cinema_challenge.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _databaseContext;
        public CustomerRepository(CinemaContext db)
        {
            _databaseContext = db;
        }
        public async Task<Customer?> CreateACustomer(string Name, string Email, int Phone)
        {
            Customer customer = new Customer()
            {
                Name = Name,
                Email = Email,
                Phone = Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _databaseContext.Customers.Add(customer);
            await _databaseContext.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer?> DeleteCustomer(int Customerid)
        {
            Customer? customer = await GetCustomerById(Customerid);
            if (customer == null)
            {
                return null;
            }
            _databaseContext.Remove(customer);
            await _databaseContext.SaveChangesAsync();

            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _databaseContext.Customers
                      .ToListAsync();
        }

        public async Task<Customer?> GetCustomerById(int Customerid)
        {
            Customer? customer = await _databaseContext.Customers
                           .Where(m => m.Id == Customerid)
                           .FirstOrDefaultAsync();
            if (customer == null)
            {
                return null;
            }
            return customer;
        }

        public async Task<Customer?> UpdateCustomer(int Customerid, string Name, string Email, int Phone)
        {
            Customer? customer = await GetCustomerById(Customerid);
            if (customer == null)
            {
                return null;
            }
            customer.Name = Name;
            customer.Email = Email;
            customer.Phone = Phone;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;
            await _databaseContext.SaveChangesAsync();

            return customer;
        }
    }
}