using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : IRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.FindAsync(id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> GetACustomer(int id)
        {
            return await _db.Customers.FindAsync(id);
        }

        public async Task<ICollection<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _db.Customers.Update(customer);
            await _db.SaveChangesAsync();
            return customer;
        }
    }
}
