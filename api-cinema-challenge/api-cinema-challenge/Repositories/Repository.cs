using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        
        public Repository(CinemaContext db)
        {
            this._db = db;
        }



        //--Customers--
        public async Task<CustomerDTO> AddCustomer(Customer entity)
        {
            //Add to the database
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            //Response
            return ConstructCustomerDTO(entity);
        }
        public async Task<ICollection<CustomerDTO>> GetCustomers()
        {
            //Get Customers
            var customers = await _db.Customers.ToListAsync();

            //Add to list of DTOs
            List<CustomerDTO> result = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                result.Add(ConstructCustomerDTO(customer));
            }

            //Response
            return result;
        }
        public async Task<CustomerDTO> UpdateCustomer(int id, Customer entity)
        {
            //Get the customer
            var customer = await _db.Customers.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            //Update the old customer
            customer.Name = entity.Name;
            customer.Email = entity.Email;
            customer.Phone = entity.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            //Update the database
            _db.Attach(customer).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            //Response
            return ConstructCustomerDTO(customer);
        }
        public async Task<CustomerDTO> RemoveCustomer(int id)
        {
            //Get the customer
            var customer = await _db.Customers.Where(c => c.Id ==id).FirstOrDefaultAsync();
            if(customer == null)
            {
                throw new Exception("Customer not found");
            }

            //Remove from the database
            _db.Remove(customer);
            await _db.SaveChangesAsync();

            //Response
            return ConstructCustomerDTO(customer);
        }
        private CustomerDTO ConstructCustomerDTO(Customer customer)
        {
            return new CustomerDTO(customer);
        }

        

        //--Movies--
        public async Task<MovieDTO> AddMovie(Movie entity)
        {
            //Add movie to the database
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            //Response
            return ConstructMovieDTO(entity);
        }
        public async Task<ICollection<MovieDTO>> GetMovies()
        {
            //Get Movies
            var movies = await _db.Movies.ToListAsync();

            //Add to list of DTOs
            List<MovieDTO> result = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                result.Add(ConstructMovieDTO(movie));
            }

            //Response
            return result;
        }
        public async Task<MovieDTO> UpdateMovie(int id, Movie entity)
        {
            //Get the movie
            var movie = await _db.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (movie == null)
            {
                throw new Exception("Movie not found");
            }

            //Update the old movie
            movie.Title = entity.Title;
            movie.Rating = entity.Rating;
            movie.Description = entity.Description;
            movie.RuntimeMins = entity.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            //Update the database
            _db.Attach(movie).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            //Response
            return ConstructMovieDTO(movie);
        }
        public async Task<MovieDTO> RemoveMovie(int id)
        {
            //Get the movie
            var movie = await _db.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (movie == null)
            {
                throw new Exception("Movie not found");
            }

            //Remove from the database
            _db.Remove(movie);
            await _db.SaveChangesAsync();

            //Response
            return ConstructMovieDTO(movie);
        }
        private MovieDTO ConstructMovieDTO(Movie movie)
        {
            return new MovieDTO(movie);
        }



        //--Screenings--
        public async Task<ScreeningDTO> AddScreening(Screening entity)
        {
            //Add screening to the database
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            //Response
            return ConstructScreeningDTO(entity);
        }
        public async Task<ICollection<ScreeningDTO>> GetScreenings(int id)
        {
            //Get the screenings
            var screenings = await _db.Screenings.Include(s => s.Movie).Where(m => m.MovieId == id).ToListAsync();
            List<ScreeningDTO> result = new List<ScreeningDTO>();
            foreach (var screening in screenings)
            {
                result.Add(ConstructScreeningDTO(screening));
            }

            //Response
            return result;
        }
        private ScreeningDTO ConstructScreeningDTO(Screening screening)
        {
            return new ScreeningDTO(screening);
        }
    }
}
