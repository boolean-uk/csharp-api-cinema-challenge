using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Screening> AddScreening(Screening screening)
        {
            _db.Screenings.Add(screening);
            var movie = await _db.Movies.FindAsync(screening.MovieId);
            movie.Screenings.ToList().Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Screening> AddScreeningMovie(Screening screening)
        {
            _db.Screenings.Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }



        public async Task<Ticket> AddTicket(Ticket ticket)
        {
            _db.Tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }

        public async Task<bool> DeleteTicket(Ticket ticket)
        {
            _db.Tickets.Remove(ticket);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var target = await _db.Customers.FindAsync(id);
            var tickets = await GetTicketsCustomer(id);
            foreach (var ticket in tickets) {
                    DeleteTicket(ticket);
                }
            _db.Customers.Remove(target);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMovie(int id)
        {
            var target = await _db.Movies.FindAsync(id);
            _db.Movies.Remove(target);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await _db.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await _db.Movies.FindAsync(id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.Include(m => m.Screenings).ToListAsync();
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            return await _db.Screenings.Where(s => s.MovieId == id).ToListAsync();
        }
        public async Task<IEnumerable<Ticket>> GetTicketsCustomer(int customerId)
        {
            return await _db.Tickets.Where(t => t.CustomerId == customerId).ToListAsync();
        }
        public async Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningId)
        {
            return await _db.Tickets.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId).ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var target = await _db.Customers.FindAsync(customer.Id);
            _db.Customers.Remove(target);
            await _db.SaveChangesAsync();

            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            var target = await (_db.Movies.FindAsync(movie.Id));
            _db.Movies.Remove(target);
            await _db.SaveChangesAsync();

            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;
        }
    }
}
