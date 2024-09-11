using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : IRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<Screening> CreateScreening(Screening screening)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.FindAsync(id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public Task<Movie> DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetACustomer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public Task<ICollection<Movie>> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Screening>> GetAllScreenings()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Ticket>> GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Screening> GetScreening(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicket(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _db.Customers.Update(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<Screening> UpdateScreening(Screening screening)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
