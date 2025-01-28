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
