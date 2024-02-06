using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Posts;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRespository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<ICollection<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer?> UpdateCustomer(int id, CustomerPost customer)
        {
            var foundCustomer = await _db.Customers.FirstOrDefaultAsync(customer => customer.Id == id);
            if (foundCustomer == null)
            {
                return null;
            }

            foundCustomer.Name = customer.Name;
            foundCustomer.Email = customer.Email;
            foundCustomer.PhoneNumber = customer.PhoneNumber;
            foundCustomer.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return foundCustomer;
        }

        public async Task<Customer?> DeleteCustomer(int id)
        {
            var foundCustomer = await _db.Customers.FirstOrDefaultAsync(customer => customer.Id == id);
            if (foundCustomer == null)
            {
                return null;
            }

            _db.Remove(foundCustomer);
            await _db.SaveChangesAsync();
            return foundCustomer;
        }
    }
}
