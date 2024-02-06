using api_cinema_challenge.Data;
using api_cinema_challenge.DTO.Payloads;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
        {
            private CinemaContext _context;

            public Repository(CinemaContext context)
            {
                _context = context;
            }

            public async Task<List<Customer>> GetAllCustomers()
            {
                return await _context.Customers.ToListAsync();
            }

            public async Task<Customer> GetCustomerById(int customerId)
            {
                return await _context.Customers.FindAsync(customerId);
            }

            public async Task<Customer> AddCustomer(Customer customer)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return customer;
            }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.Email = customer.Email;
                existingCustomer.Phone = customer.Phone;
                await _context.SaveChangesAsync();
            }
            return existingCustomer;
        }



        public async Task<bool> DeleteCustomer(int customerId)
            {
                var existingCustomer = await _context.Customers.FindAsync(customerId);
                if (existingCustomer == null)
                {
                    throw new InvalidOperationException("Customer not found");
                }

                _context.Customers.Remove(existingCustomer);
                await _context.SaveChangesAsync();
                return true;
        }
        // End customer

        // Movie Methods
        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> UpdateMovie(int id, Movie movie)
        {
            var existingMovie = await _context.Movies.FindAsync(id);
            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.Rating = movie.Rating;
                existingMovie.Description = movie.Description;
                existingMovie.RuntimeMins = movie.RuntimeMins;
                await _context.SaveChangesAsync();
            }
            return existingMovie;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _context.Movies.FindAsync(id);
        }


        public async Task<bool> DeleteMovie(int id)
        {
            var existingMovie = await _context.Movies.FindAsync(id);
            if (existingMovie == null)
            {
                throw new InvalidOperationException("Movie not found");
            }

            _context.Movies.Remove(existingMovie);
            await _context.SaveChangesAsync();
            return true;
        }

        // Screening Methods
        public async Task<List<Screening>> GetAllScreenings(int movieId)
        {
            return await _context.Screenings
                .Include(s => s.Movie)
                .Where(s => s.MovieId == movieId) // Filter by movieId
                .ToListAsync();
        }

        public async Task<Screening> CreateScreening(int movieId, CreateScreeningPayload payload)
        {
            var screening = new Screening
            {
                ScreenNumber = payload.ScreenNumber,
                Capacity = payload.Capacity,
                StartsAt = payload.StartsAt,
                MovieId = movieId
            };
            var addedScreening = await AddScreening(screening);
            return addedScreening;
        }

        public async Task<Screening> AddScreening(Screening screening)
        {
            _context.Screenings.Add(screening);
            await _context.SaveChangesAsync();
            return screening;
        }
    }

    //Ticket
}
