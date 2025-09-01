using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CinemaContext _ctx;
        public CustomerRepository(CinemaContext ctx) => _ctx = ctx;

        public async Task<Customer> AddAsync(Customer c)
        {
            _ctx.Customers.Add(c);
            await _ctx.SaveChangesAsync();
            return c;
        }

        public Task<List<Customer>> GetAllAsync()
            => _ctx.Customers.AsNoTracking().ToListAsync();

        public Task<Customer?> GetAsync(int id)
            => _ctx.Customers.FindAsync(id).AsTask();

        public async Task<Customer?> UpdateAsync(int id, Customer update)
        {
            var c = await _ctx.Customers.FindAsync(id);
            if (c == null) return null;
            c.Name = update.Name; c.Email = update.Email; c.Phone = update.Phone;
            await _ctx.SaveChangesAsync();
            return c;
        }

        public async Task<Customer?> DeleteAsync(int id)
        {
            var c = await _ctx.Customers.FindAsync(id);
            if (c == null) return null;
            _ctx.Customers.Remove(c);
            await _ctx.SaveChangesAsync();
            return c;
        }
    }
}
