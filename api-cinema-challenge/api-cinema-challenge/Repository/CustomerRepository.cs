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

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers
                .Include(x => x.Tickets)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.Customers
                .Include(x => x.Tickets)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Customer> UpdateCustomer(int id, Customer entity)
        {
            var target = await _db.Customers
                .Include(x => x.Tickets)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .FirstOrDefaultAsync(x => x.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.Name = entity.Name;
            target.Email = entity.Email;
            target.Phone = entity.Phone;

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return target;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customerTarget = await _db.Customers
                .Include(x => x.Tickets)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (customerTarget == null)
            {
                return null;
            }
            
            // Removes related tickets
            foreach (Ticket t in customerTarget.Tickets)
            {
                _db.Tickets.Remove(t);
            }

            _db.Customers.Remove(customerTarget);
            await _db.SaveChangesAsync();

            return customerTarget;
        }
    }
}
