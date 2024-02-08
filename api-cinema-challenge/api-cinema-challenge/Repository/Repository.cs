using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _dbContext;
        public Repository(CinemaContext db)
        {
            _dbContext = db;
        }

        public async Task<Customer> CreateCustomer(CustomerPost customer)
        {
            var nextId = _dbContext.Customers.Count();
            Customer newCustomer = new Customer()
            {
                Id = nextId + 1,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _dbContext.Add(newCustomer);
            _dbContext.SaveChanges();
            return newCustomer;
        }

        public async Task<Movie> CreateMovie(MoviePost movie)
        {
            var nextId = _dbContext.Movies.Count();
            Movie newMovie = new Movie()
            {
                Id = nextId + 1,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _dbContext.Add(newMovie);
            _dbContext.SaveChanges();
            return newMovie;
        }

        public async Task<Screening> CreateScreening(ScreeningPost screening, int movieId)
        {
            var nextId = _dbContext.Screenings.Count();
            Screening newScreening = new Screening()
            {
                Id = nextId + 1,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MovieId = movieId,
                Movie = _dbContext.Movies.Include(s => s.Screenings).FirstOrDefault(x => x.Id == movieId)
            };

            _dbContext.Add(newScreening);
            _dbContext.SaveChanges();
            return newScreening;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _dbContext.Customers.Select(c => new Customer()
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            }).SingleOrDefaultAsync(c => c.Id == id);

            _dbContext.Remove(customer);
            _dbContext.SaveChanges();

            return customer;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _dbContext.Movies.Select(m => new Movie()
            {
                Id = m.Id,
                Title = m.Title,
                Rating = m.Rating,
                Description = m.Description,
                RuntimeMins = m.RuntimeMins,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt
            }).SingleOrDefaultAsync(m => m.Id == id);

            _dbContext.Remove(movie);
            _dbContext.SaveChanges();

            return movie;
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            var customers = from customer in _dbContext.Customers
                           select new CustomerDTO()
                           {
                               Id = customer.Id,
                               Name = customer.Name,
                               Email = customer.Email,
                               Phone = customer.Phone,
                               CreatedAt = customer.CreatedAt,
                               UpdatedAt = customer.UpdatedAt
                               
                           };
            return await customers.ToListAsync();
        }

        public async Task<IEnumerable<MovieDTO>> GetMovies()
        {
            var movies = from movie in _dbContext.Movies
                            select new MovieDTO()
                            { 
                                Id= movie.Id,
                                Title = movie.Title,
                                Rating = movie.Rating,
                                Description = movie.Description,
                                RuntimeMins = movie.RuntimeMins,
                                CreatedAt = movie.CreatedAt,
                                UpdatedAt = movie.UpdatedAt
                            };
            return await movies.ToListAsync();
        }

        public async Task<IEnumerable<ScreeningDTO>> GetScreenings(int id)
        {
            var screenings = from screening in _dbContext.Screenings where screening.MovieId == id
                         select new ScreeningDTO()
                         {
                             Id = screening.Id,
                             ScreenNumber = screening.ScreenNumber,
                             Capacity = screening.Capacity,
                             StartsAt = screening.StartsAt,
                             CreatedAt = screening.CreatedAt,
                             UpdatedAt = screening.UpdatedAt
                         };
            return await screenings.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(CustomerPut customer, int id)
        {
            Customer updatedCustomer = new Customer()
            {
                Id = id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                UpdatedAt = DateTime.UtcNow
            };

            _dbContext.Attach(updatedCustomer);
            _dbContext.Entry(updatedCustomer).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return updatedCustomer;
        }

        public async Task<Movie> UpdateMovie(MoviePut movie, int id)
        {
            Movie updated = new Movie()
            {
                Id = id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                UpdatedAt = DateTime.UtcNow
            };

            _dbContext.Attach(updated);
            _dbContext.Entry(updated).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return updated;
        }
    }
}
