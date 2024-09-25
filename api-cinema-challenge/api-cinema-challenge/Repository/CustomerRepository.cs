using api_cinema_challenge.Controller;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Customer> Create(Customer entity)
        {
            await _db.Customers.AddAsync(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<Customer> Delete(int id)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var entity = await _db.Customers.ToListAsync();
            return entity;
        }

        public async Task<Customer> Update(int id, Customer customer)
        {
            var newCustomer = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);
            newCustomer.Name = customer.Name;
            newCustomer.Email = customer.Email;
            newCustomer.Phone = customer.Phone;
            newCustomer.UpdatedAt = customer.UpdatedAt;
            await _db.SaveChangesAsync();

            return newCustomer;
        }

    }
}
