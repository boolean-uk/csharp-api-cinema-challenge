using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
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

        public async Task<Customer> CreateCustomer(Customer entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customerTarget = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customerTarget == null)
            {
                return null;
            }

            var ticketTarget = await _db.Tickets.FirstOrDefaultAsync(x => x.CustomerId == id);
            if (ticketTarget != null)
            {
                ticketTarget.CustomerId = 0;
            }

            _db.Customers.Remove(customerTarget);
            await _db.SaveChangesAsync();
            return customerTarget;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.Customers
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers
                .Include(x => x.Tickets)
                .ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(int id, Customer entity)
        {
            var target = await _db.Customers
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.Name = entity.Name;
            target.Email = entity.Email;
            target.Phone = entity.Phone;

            return target;
        }
    }
}
