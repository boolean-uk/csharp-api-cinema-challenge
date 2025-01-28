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


        // CUSTOMERS _______________________________________________________
        public Task<IEnumerable<Customer>> GetCustomers()
        {
            throw new NotImplementedException();
        }
        public Task<Customer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        public Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        // MOVIES _______________________________________________________


        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        public Task<Movie> GetMovie(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
        public Task<Movie> UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
        public Task<Movie> DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        // SCREENINGS _______________________________________________________
        public Task<IEnumerable<Screening>> GetScreenings()
        {
            throw new NotImplementedException();
        }
        public Task<Screening> GetScreening(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Screening> CreateScreening(Screening screening)
        {
            throw new NotImplementedException();
        }
        public Task<Screening> UpdateScreening(int id, Screening screening)
        {
            throw new NotImplementedException();
        }

        public Task<Screening> DeleteScreening(int id)
        {
            throw new NotImplementedException();
        }

        // TICKETS _______________________________________________________


        public Task<IEnumerable<Ticket>> GetTickets()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> CreateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
        public Task<Ticket> UpdateTicket(int id, Ticket ticket)
        {
            throw new NotImplementedException();
        }
        public Task<Ticket> DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }


    }
}
