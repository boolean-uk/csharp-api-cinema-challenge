using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _databaseContext;
        public CustomerRepository (CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Customer> AddAsync(Customer entity)
        {
            //await _databaseContext.Customers.AddAsync(entity);
            _databaseContext.Customers.Attach(entity).State = EntityState.Added;
            await _databaseContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _databaseContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _databaseContext.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateAsync(Customer entity)
        {
            _databaseContext.Attach(entity).State = EntityState.Modified;
            await _databaseContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> DeleteAsync(int id)
        {
            var removed = await GetCustomerById(id);
            if (removed != null)
            {
                _databaseContext.Remove(removed);
                await _databaseContext.SaveChangesAsync();
                return removed;
            }
            else
            {
                return null;
            }
        }
    }
}
