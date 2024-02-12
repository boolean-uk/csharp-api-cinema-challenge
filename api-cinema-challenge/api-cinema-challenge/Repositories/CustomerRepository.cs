using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;


namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _dbContext;

        public CustomerRepository(CinemaContext db)
        {
            _dbContext = db;
        }

        //Customer
        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _dbContext.Customers.FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var aCustomer = await GetCustomerById(id);
            
            aCustomer.Name = customer.Name; 
            aCustomer.Email = customer.Email;
            aCustomer.PhoneNumber = customer.PhoneNumber;
            aCustomer.UpdatedAt = DateTime.UtcNow;
            _dbContext.SaveChanges();
            return aCustomer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _dbContext.Customers.FirstAsync(x => x.Id == id);
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
            return customer;
        }
    }
}
