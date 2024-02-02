using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;
        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Customer?> CreateCustomer(string name, string email, int phoneNr, int ScreeningId)
        {
            //Create customer to return
            Customer customer = new Customer();
            
            //Check data is valid
            if(IsValidEmail(email))
            {
                //Populate the customer with payload data
                customer.Name = name;
                customer.Email = email;
                customer.PhoneNr = phoneNr;
                customer.ScreeningId = ScreeningId;
            }
            else
            {
                return null;
            }
            //add customer to database and save it + return
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return customer;
        }
        public async Task<Customer?> GetCustomer(int id)
        {
            return await _db.Customers.Include(y => y.Screening).SingleOrDefaultAsync(y => y.Id == id);
        }
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.Include(x => x.Screening).ToListAsync();
        }
        public async Task<Customer?> UpdateCustomer(int id, string Name, string Email, int? PhoneNr, int? ScreeningId)
        {
            //Get customer to be updated
            var customer = await GetCustomer(id);
            //Add updated data to movie
            customer.Name = Name;
            customer.Email = Email;
            customer.PhoneNr = (int)PhoneNr;
            customer.ScreeningId = (int)ScreeningId;
            customer.UpdatedAt = DateTime.UtcNow;
            //Return customer now with updated data and save changes
            _db.SaveChanges();
            return customer;
        }
        public async Task<Customer?> DeleteCustomer(int id)
        {
            var customer = await GetCustomer(id);
            _db.Customers.Remove(customer);
            _db.SaveChanges();
            return customer;
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
