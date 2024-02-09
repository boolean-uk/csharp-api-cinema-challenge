using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Xml.Linq;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;
        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Customer> CreateCustomer(Customer request)
        {
            if(!request.Email.Contains("@"))
            {
                throw new ArgumentException("Email must be a proper email address");
            }
            Customer customer = new Customer();
            customer.Name = request.Name;
            customer.Email = request.Email;
            customer.Phone = request.Phone;
            customer.CreatedAt = DateTime.Now.ToUniversalTime();
            customer.UpdatedAt = DateTime.Now.ToUniversalTime();
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(Customer request)
        {
            var customer = await _db.Customers.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (customer == null)
            {
                throw new ArgumentException("Customer not found");
            }
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        

        public async Task<Customer> GetCustomerById(CustomerDTO request)
        {
            return await _db.Customers.Where(x => x.Id == request.Id).FirstOrDefaultAsync()
                ?? throw new ArgumentException($"Customer with id: {request.Id} does not exist");
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.Customers.Where(x => x.Id == id).FirstOrDefaultAsync()
               ?? throw new ArgumentException($"Customer with id: {id} does not exist");
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            List<Customer> customers =  await _db.Customers.ToListAsync();
            return customers;
        }

      

        public async Task<Customer> UpdateCustomer(Customer request)
        {
           //Magic function Nigel showed me which helps save the modified customer entity
            _db.Entry(request).State = EntityState.Modified;
          
            await _db.SaveChangesAsync();
            return request;
        }
    }
}
