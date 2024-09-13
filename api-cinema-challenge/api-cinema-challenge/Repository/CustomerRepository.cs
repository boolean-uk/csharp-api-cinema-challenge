using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository(CinemaContext db) : IRepository<Customer>
    {
        public async Task<Customer> Add(Customer entity)
        {
            await db.Customers.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> Delete(int id)
        {
            var customer = await db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            db.Customers.Remove(customer);
            await db.SaveChangesAsync();
            return customer;
        }

        public async Task<List<Customer>> GetAll()
        {
            return await db.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            var customer = await db.Customers.SingleOrDefaultAsync(c => c.Id == id);
            return customer;
        }


        public async Task<Customer> Update(Customer entity)
        {
            var customer = await db.Customers.SingleOrDefaultAsync(c => c.Id == entity.Id);
            customer.Name = entity.Name;
            customer.Email = entity.Email;
            customer.PhoneNumber = entity.PhoneNumber;
            customer.UpdatedAt = DateTime.UtcNow;
           
            await db.SaveChangesAsync();
            
            return customer;
        }

        public async Task<List<Customer>> GetAllById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
