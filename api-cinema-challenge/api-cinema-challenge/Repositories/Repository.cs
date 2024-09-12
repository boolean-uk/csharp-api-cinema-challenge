using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Screening> CreateScreening(Screening screening)
        {
            _db.Screenings.Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.FindAsync(id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _db.Movies.FindAsync(id);
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Customer> GetACustomer(int id)
        {
            return await _db.Customers.FindAsync(id);
        }

        public async Task<ICollection<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<ICollection<Movie>> GetAllMovies()
        {
            return await _db.Movies.Include(s => s.Screenings).ToListAsync();
        }

        public async Task<ICollection<Screening>> GetAllScreenings()
        {
            return await _db.Screenings.ToListAsync();
        }

        public async Task<ICollection<Ticket>> GetAllTickets()
        {
            return await _db.Tickets.ToListAsync();
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await _db.Movies.Include(s => s.Screenings).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Screening> GetScreening(int id)
        {
            return await _db.Screenings.FindAsync(id);
        }

        public async Task<Ticket> GetTicket(int id)
        {
            return await _db.Tickets.FindAsync(id);
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _db.Customers.Update(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            _db.Movies.Update(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Screening> UpdateScreening(Screening screening)
        {
            _db.Screenings.Update(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Ticket> UpdateTicket(Ticket ticket)
        {
            _db.Tickets.Update(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }
    }
}
