using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _cinemaContext;

        public Repository(CinemaContext db)
        {
            _cinemaContext = db;
        }

        //Get Customers
        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            var customers = from customer in _cinemaContext.Customers
                            select new CustomerDTO()
                            {
                                Id = customer.Id,
                                CustomerName = customer.CustomerName,
                                EmailAdress = customer.EmailAdress,
                                PhoneNumber = customer.PhoneNumber,
                                CreatedAt = customer.CreatedAt,
                                UpdatedAt = customer.UpdatedAt
                            };
            return await customers.ToListAsync();
        }

        //Create Customer
        public async Task<Customer> CreateCustomer(CustomerPost customer, int id)
        {
            var createCustomer = new Customer()
            {
                Id = id,
                CustomerName = customer.CustomerName,
                EmailAdress = customer.EmailAdress,
                PhoneNumber = customer.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow

            };

            _cinemaContext.Customers.Add(createCustomer);
            await _cinemaContext.SaveChangesAsync();

            return createCustomer;
        }



        public async Task<Customer> UpdateCustomer(int id, CustomerPost customer)
        {
            var existingCustomer = await _cinemaContext.Customers.FirstOrDefaultAsync(c => c.Id == id);

            if (existingCustomer != null)
            {
                // Update fields only if provided
                if (!string.IsNullOrEmpty(customer.CustomerName) && customer.CustomerName != "string") // Check for null instead of empty string
                    existingCustomer.CustomerName = customer.CustomerName;

                if (!string.IsNullOrEmpty(customer.EmailAdress) && customer.EmailAdress != "string")
                    existingCustomer.EmailAdress = customer.EmailAdress;

                if (!string.IsNullOrEmpty(customer.PhoneNumber) && customer.PhoneNumber != "string")
                    existingCustomer.PhoneNumber = customer.PhoneNumber;

                existingCustomer.UpdatedAt = DateTime.UtcNow;

                await _cinemaContext.SaveChangesAsync();
            }

            return existingCustomer;
        }


        // Delete Customer
        public async Task<Customer> DeleteCustomer(int id)
        {
            var customerToDelete = await _cinemaContext.Customers.FirstOrDefaultAsync(c => c.Id == id);

            if (customerToDelete != null)
            {
                _cinemaContext.Customers.Remove(customerToDelete);
                await _cinemaContext.SaveChangesAsync();
            }

            return customerToDelete;
        }

        //Get All Movies
        public async Task<IEnumerable<MovieDTO>> GetMovies()
        {
            var movies = from movie in _cinemaContext.Movies
                         select new MovieDTO()
                         {
                             Id = movie.MovieId,
                             Title = movie.Title,
                             Rating = movie.Rating,
                             Description = movie.Description,
                             RuntimeMins = movie.RuntimeMins,
                             CreatedAt = movie.CreatedAt,
                             UpdatedAt = movie.UpdatedAt,
                             Screenings = movie.Screenings.Select(x => new ScreeningDTO()
                             {
                                 Id = x.ScreeningId,
                                 ScreenNumber = x.ScreenNumber,
                                 ScreenCapacity = x.ScreenCapacity,
                                 StartsAt = x.StartsAt,
                                 CreatedAt = x.CreatedAt,
                                 UpdatedAt = x.UpdatedAt
                             })
                            };

            return await movies.ToListAsync();
        }

        // Create Movie
        public async Task<Movie> CreateMovie(MoviePost movie, int id)
        {
            var createMovie = new Movie()
            {
                MovieId = id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Screenings = movie.Screenings.Select(x => new Screening() 
                {
                    ScreenNumber = x.ScreenNumber,
                    ScreenCapacity = x.ScreenCapacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    MovieId = id
                }).ToArray()
            };

            _cinemaContext.Movies.Add(createMovie);
            await _cinemaContext.SaveChangesAsync();
            {
                
               
                await _cinemaContext.SaveChangesAsync();
            }

            return createMovie;
        }



        /* Create Movie CORE
        public async Task<Movie> CreateMovie(MoviePost movie, int id)
        {
            var createMovie = new Movie()
            {
                MovieId = id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
                
            };

            _cinemaContext.Movies.Add(createMovie);
            await _cinemaContext.SaveChangesAsync();

            return createMovie;
        }
        */

        //Update Movie CORE
        /*
        public async Task<Movie> UpdateMovie(int id, MoviePost movie)
        {
            var existingMovie = await _cinemaContext.Movies.FirstOrDefaultAsync(m => m.MovieId == id);

            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.Rating = movie.Rating;
                existingMovie.Description = movie.Description;
                existingMovie.RuntimeMins = movie.RuntimeMins;
                existingMovie.UpdatedAt = DateTime.UtcNow;

                await _cinemaContext.SaveChangesAsync();
            }

            return existingMovie;
        }
        */

        //Update Movie Extension
        public async Task<Movie> UpdateMovie(int id, MoviePost movie)
        {
            var updatedMovie = await _cinemaContext.Movies.FirstOrDefaultAsync(m => m.MovieId == id);

            if (updatedMovie != null)
            {

                // Update fields only if provided
                if (!string.IsNullOrEmpty(movie.Title) && movie.Title != "string")
                    updatedMovie.Title = movie.Title;

                if (!string.IsNullOrEmpty(movie.Rating) && movie.Rating != "string")
                    updatedMovie.Rating = movie.Rating;

                if (!string.IsNullOrEmpty(movie.Description) && movie.Description != "string")
                    updatedMovie.Description = movie.Description;

                if (movie.RuntimeMins != 0)
                    updatedMovie.RuntimeMins = movie.RuntimeMins;

                updatedMovie.UpdatedAt = DateTime.UtcNow;

                await _cinemaContext.SaveChangesAsync();
            }

            return updatedMovie;
        }

        // Delete Movie
        public async Task<MovieDTO> DeleteMovie(int id)
        {
            var movieToDelete = await _cinemaContext.Movies.FirstOrDefaultAsync(m => m.MovieId == id);

            if (movieToDelete != null)
            {
                _cinemaContext.Movies.Remove(movieToDelete);
                await _cinemaContext.SaveChangesAsync();
            }

            var movieDTO = new MovieDTO()
            {
                Id = id,
                Title = movieToDelete.Title,
                Rating = movieToDelete.Rating,
                Description = movieToDelete.Description,
                RuntimeMins = movieToDelete.RuntimeMins,
                CreatedAt = movieToDelete.CreatedAt,
                UpdatedAt = movieToDelete.UpdatedAt
            };
               
            return movieDTO;
        }


        //Get all Screenings for Movie
        public async Task<IEnumerable<ScreeningDTO>> GetScreeningsForMovie(int movieId)
        {
            var screenings = from screening in _cinemaContext.Screenings
                             where screening.MovieId == movieId
                             select new ScreeningDTO()
                             {
                                 Id = screening.ScreeningId,
                                 ScreenNumber = screening.ScreenNumber,
                                 ScreenCapacity = screening.ScreenCapacity,
                                 StartsAt = screening.StartsAt,
                                 CreatedAt = screening.CreatedAt,
                                 UpdatedAt = screening.UpdatedAt
                                
                             };

            return await screenings.ToListAsync();
        }

        // Create Screening for a Movie
        public async Task<Screening> CreateScreeningForMovie( ScreeningPost screening, int movieId)
        {
            Screening createScreening = new Screening()
            {
                ScreenNumber = screening.ScreenNumber,
                ScreenCapacity = screening.ScreenCapacity,
                StartsAt = screening.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MovieId = movieId

            };

            _cinemaContext.Screenings.Add(createScreening);
            await _cinemaContext.SaveChangesAsync();

            return createScreening;
        }

        public async Task<Ticket> BookTicket(int customerId, int screeningId, int numSeats)
        {
            var screening = await _cinemaContext.Screenings.FirstOrDefaultAsync(s => s.ScreeningId == screeningId);
            var customer = await _cinemaContext.Customers.FirstOrDefaultAsync(c => c.Id == customerId);

            if (screening == null || customer == null)
            {
                return null; 
            }

            var availableSeats = screening.ScreenCapacity - screening.Tickets.Sum(t => t.SeatNumber);
            if (availableSeats < numSeats)
            {
                return null; 
            }

            var ticket = new Ticket
            {
                SeatNumber = numSeats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CustomerId = customerId,
                ScreeningId = screeningId
                
            };

            screening.Tickets.Add(ticket);
            await _cinemaContext.SaveChangesAsync();

            var ticketToReturn = new Ticket
            {
                TicketId = ticket.TicketId,
                SeatNumber = ticket.SeatNumber,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt
            };

            return ticketToReturn;
        }

        //Get Tickets
        public async Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningId)
        {
            var tickets = await _cinemaContext.Tickets.Where(t => t.ScreeningId == screeningId && t.CustomerId == customerId).ToListAsync();
            return tickets;
        }


    }
}
