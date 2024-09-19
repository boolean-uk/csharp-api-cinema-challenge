using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();
            return await _db.Customers
                .Include(c => c.Tickets)
                .ThenInclude(c => c.Screening)
                .ThenInclude(c => c.Movie)
                .FirstOrDefaultAsync(c => c.Id == customer.Id);
        }

        public async Task DeleteCustomer(int id)
        {
            Customer target = await _db.Customers.FindAsync(id);
            _db.Customers.Remove(target);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers
                .Include(c => c.Tickets)
                .ThenInclude(c => c.Screening)
                .ThenInclude(c => c.Movie)
                .ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.Customers
               .Include(c => c.Tickets)
               .ThenInclude(c => c.Screening)
               .ThenInclude(c => c.Movie)
               .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Customer> UpdateCustomer(int id, Customer newValues)
        {
            Customer target = await _db.Customers
               .Include(c => c.Tickets)
               .ThenInclude(c => c.Screening)
               .ThenInclude(c => c.Movie)
               .FirstOrDefaultAsync(c => c.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.Name = newValues.Name;
            target.Email = newValues.Email;
            target.Phone = newValues.Phone;

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return target;
        }
    }
}
