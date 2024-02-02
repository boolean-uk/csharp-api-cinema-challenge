using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories.customer
{
    public class CustomerRepo : ICustomerRepository
    {
        CinemaContext _db;
        public CustomerRepo(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> Add(string name, string email, string phone)
        {
            var newCustomer = await _db.Customers.AddAsync(new Customer { Name = name, Email = email, Phone = phone });
            await _db.SaveChangesAsync();
            return newCustomer.Entity;
        }

        public async Task<Customer?> Delete(int id)
        {
            var customer = await Get(id);
            if (customer == null) { return null; }

            _db.Customers.Remove(customer);

            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer?> Get(int id)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return customer;
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _db.Customers.Include(c => c.Bookings).ToListAsync();
        }

        public async Task<Customer?> Update(int id, string name, string email, string phone)
        {
            var customer = await Get(id);
            if (customer == null) { return null; }

            if (!string.IsNullOrWhiteSpace(name)) { customer.Name = name; }
            if (!string.IsNullOrWhiteSpace(email)) { customer.Email = email; }
            if (!string.IsNullOrWhiteSpace(phone)) { customer.Phone = phone; }
            customer.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();

            return customer;
        }
    }
}
