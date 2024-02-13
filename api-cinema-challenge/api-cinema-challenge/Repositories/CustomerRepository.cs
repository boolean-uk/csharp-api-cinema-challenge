using api_cinema_challenge.Data;
using api_cinema_challenge.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _cc;

        public CustomerRepository(CinemaContext cc)
        {
            _cc = cc;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await _cc.Customers.AddAsync(customer);
            await _cc.SaveChangesAsync();
            customer.CreatedAt = DateTime.Now;
            return customer;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _cc.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            Customer entity = await GetCustomerById(id);
            _cc.Remove(entity);
            await _cc.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _cc.Customers.Include(c => c.Screenings).ToListAsync();    
        }

        public async Task<Customer> UpdateCustomer(Customer customer, int id)
        {
            Customer dbCustomer = await GetCustomerById(id);
            dbCustomer.UpdatedAt = DateTime.Now;
            dbCustomer = customer;
            await _cc.SaveChangesAsync();
            return await GetCustomerById(id);
            
        }

        public async Task<Ticket> BookTicket(Ticket ticket)
        {
            await _cc.Tickets.AddAsync(ticket);
            await _cc.SaveChangesAsync();
            ticket.CreatedAt = DateTime.Now;
            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            return await _cc.Tickets.Include(t => t.Screen).Include(t => t.Customer).ToListAsync();
        }
    }
}
