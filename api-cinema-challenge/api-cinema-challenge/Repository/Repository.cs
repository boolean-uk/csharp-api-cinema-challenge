using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db {  get; set; }

        public Repository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Customer> CreateACustomer(Customer customer)
        {
            _db.Customers.Add(customer);
           await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> CreateAMovie(Movie movie)
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

        public async Task<Customer> DeleteACustomer(int customerId)
        {
            Customer customer =  await _db.Customers.FirstOrDefaultAsync(x => x.Id == customerId);
             _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Movie> DeleteAMovie(int movieId)
        {
            Movie movie = await _db.Movies.FirstOrDefaultAsync(x => x.Id == movieId);
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return movie;
        }

        public async Task<IEnumerable<Screening>> GetAllCScreenings(int movieId)
        {
            return await _db.Screenings.Where(x => x.MovieId == movieId).ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Customer> UpdateACustomer(Customer newCustomer)
        {
            Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == newCustomer.Id);
            customer.Name = newCustomer.Name;
            customer.Email = newCustomer.Email;
            customer.Phone = newCustomer.Phone;
            await _db.SaveChangesAsync();
           
            return newCustomer;

        }

        public async Task<Movie> UpdateAMovie(Movie newMovie)
        {
            Movie movie = await _db.Movies.FirstOrDefaultAsync(c => c.Id == newMovie.Id);
            movie.Title = newMovie.Title;
            movie.Rating = newMovie.Rating;
            movie.Description = newMovie.Description;
            movie.RuntimeMins = newMovie.RuntimeMins;
            await _db.SaveChangesAsync();

            return newMovie;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
