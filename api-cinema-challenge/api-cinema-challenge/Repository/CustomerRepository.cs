using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var exists = _db.Customers.Where(c => c.Id == customer.Id).Any();
            if (exists) return null;

            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var exists = await _db.Customers.AnyAsync(x => x.Id == id);
            if (!exists) 
            {
                return null; 
            }

            var entity = await _db.Customers.FirstAsync(x => x.Id == id);
            _db.Customers.Remove(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var entity = await _db.Customers.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (entity is null)
            {
                return null;
            }

            return entity;
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _db.Customers.Update(customer);
            await _db.SaveChangesAsync();

            return customer;
        }
    }
}
