using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Payload;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : IRepository<Customer, CustomerPayload>
    {
        CinemaContext _db;
        public CustomerRepository(CinemaContext context) 
        {
            _db = context;
        }

        public async Task<Customer> Create(CustomerPayload entity)
        {
            Customer customer = new Customer()
            {
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            await _db.AddAsync(customer);
            await _db.SaveChangesAsync();
            return await _db.Customers.FirstOrDefaultAsync(c => c.Id == customer.Id);
        }

        public async Task<Customer> Delete(int id)
        {
            Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null)
            {
                return null;
            }
            _db.Remove(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> Update(CustomerPayload entity, int id)
        {
            Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null)
            {
                return null;
            }
            customer.Name = entity.Name;
            customer.Email = entity.Email;
            customer.Phone = entity.Phone;
            customer.UpdatedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();
            return customer;
        }
    }
}