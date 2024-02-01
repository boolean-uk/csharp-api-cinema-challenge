using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository {

    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db) {
            _db = db;
        }
        public Task<Customer> CreateCustomer(string name, string email, string phone)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers
                .Include(tickets => tickets.Tickets)
                .ThenInclude(ticket => ticket.Movie)
                .Include(tickets => tickets.Tickets)
                .ThenInclude(movie => movie.Screening)
                .ToListAsync();
        }

        public Task<Customer> GetCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}