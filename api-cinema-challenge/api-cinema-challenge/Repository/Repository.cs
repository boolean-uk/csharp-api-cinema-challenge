using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;


namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private DataContext _db;

        public Repository(DataContext db)

        {
            _db = db;

        }

        public async Task<Customer> GetCustomerById(int customerId)
        {

            var customer = await _db.Customers.FirstOrDefaultAsync(x => x.Id == customerId);
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        { 
            var customers = await _db.Customers.ToListAsync();

            return customers;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        { 
            await _db.Customers.AddAsync(customer); 
            await _db.SaveChangesAsync();
            return customer;
        
        }

        public async Task<Customer> UpdateCustomer(int customerId, Customer customer )
        {
            var customerToUpdate = await GetCustomerById(customerId);

            customerToUpdate.Name = customer.Name;
            customerToUpdate.Email = customer.Email;
            customerToUpdate.Phone = customer.Phone;
            customerToUpdate.UpdatedAt = DateTime.UtcNow;

            _db.Customers.Update(customerToUpdate);
            await _db.SaveChangesAsync();


            return customer;            
        
        }

        public async Task<Customer> DeleteCustomer(int customerId)

        {
            var customer = await GetCustomerById(customerId);

            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return customer;
        
        
        }



    }


}
