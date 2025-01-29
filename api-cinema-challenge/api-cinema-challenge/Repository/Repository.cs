using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
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
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }
        public async Task<Customer?> GetCustomer(int id)
        {
            return await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Customer> CreateCustomer(CustomerDTO customerDTO)
        {
            Customer customer = new Customer()
            {
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _db.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer?> UpdateCustomer(int id, CustomerDTO customer)
        {
            var customerToUpdate = await _db.Customers.FirstOrDefaultAsync(m => m.Id == id);

            if (customerToUpdate == null)
            {
                return null;
            }
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Email = customer.Email;
            customerToUpdate.Phone = customer.Phone;
            customerToUpdate.UpdatedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();

            return customerToUpdate;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customerToDelete = await _db.Customers.FirstOrDefaultAsync(m => m.Id == id);
            if (customerToDelete == null)
            {
                return null;
            }
            _db.Customers.Remove(customerToDelete);
            await _db.SaveChangesAsync();
            return customerToDelete;
        }

        // MOVIES _______________________________________________________


        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        public async Task<Movie?> GetMovie(int id)
        {
            return await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<Movie> CreateMovie(MovieDTO movieDTO)
        {
            Movie movie = new Movie()
            {
                Title = movieDTO.Title,
                Rating = movieDTO.Rating,
                RuntimeMins = movieDTO.RuntimeMins,
                Description = movieDTO.Description,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };


            await _db.AddAsync(movie);
            await _db.SaveChangesAsync();

            if (movieDTO.Screenings != null)
            {
                foreach (var s in movieDTO.Screenings)
                {
                    await this.CreateScreening(s, movie.Id);
                }
            }
            return movie;
        }
        public async Task<Movie?> UpdateMovie(int id, MovieDTO movie)
        {
            var movieToUpdate = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movieToUpdate == null)
            {
                return null;
            }
            movieToUpdate.Title = movie.Title;
            movieToUpdate.Rating = movie.Rating;
            movieToUpdate.RuntimeMins = movie.RuntimeMins;
            movieToUpdate.Description = movie.Description;
            movieToUpdate.UpdatedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();

            return movieToUpdate;
        }
        public async Task<Movie?> DeleteMovie(int id)
        {
            var movieToDelete = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if(movieToDelete == null)
            {
                return null;
            }
            _db.Movies.Remove(movieToDelete);
            await _db.SaveChangesAsync();
            return movieToDelete;
        }

        // SCREENINGS _______________________________________________________
        public async Task<IEnumerable<Screening>?> GetScreenings(int movieId)
        {
            var movie = await this.GetMovie(movieId);
            if(movie == null)
            {
                return null;
            }

            return await _db.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
        }
        public async Task<Screening?> GetScreening(int id)
        {
            return await _db.Screenings.FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<Screening> CreateScreening(ScreeningDTO screeningDTO, int movieId)
        {
            Screening screening = new Screening()
            {
                ScreenNumber = screeningDTO.ScreenNumber,
                Capacity = screeningDTO.Capacity,
                StartsAt = screeningDTO.StartsAt,
                MovieId = movieId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            await _db.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;
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

        // MISC _______________________________________________________
        public Task<ApiResponse<T>> GeneratePayload<T>(T data)
        {
            return Task.FromResult(new ApiResponse<T>
            {
                Status = "success",
                Data = data
            });
        }
        public Task<ApiResponse<T>> GenerateErrorPayload<T>(T data, string message)
        {
            return Task.FromResult(new ApiResponse<T>
            {
                Status = message,
                Data = data
            });
        }
    }
}
