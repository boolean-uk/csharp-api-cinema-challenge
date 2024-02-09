using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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
            var screeningsNextId = _dbContext.Screenings.Count();
            Movie newMovie = new Movie()
            {
                Id = nextId + 1,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Screenings = movie.Screenings.Select(x => new Screening()
                {
                    Id = screeningsNextId + 1,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    MovieId = nextId
                }).ToList(),
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

        public async Task<Ticket> CreateTicket(int customerId, int screeningId, TicketPost ticket)
        {
            var nextId = _dbContext.Tickets.Count();
            Ticket newTicket = new Ticket()
            {
                Id = nextId + 1,
                NumSeats = ticket.NumSeats,
                CustomerId = customerId,
                Customer = _dbContext.Customers.Include(t => t.Tickets).FirstOrDefault(x => x.Id == customerId),
                ScreeningId = screeningId,
                Screening = _dbContext.Screenings.Include(t => t.Tickets).FirstOrDefault(x => x.Id == screeningId),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _dbContext.Add(newTicket);
            _dbContext.SaveChanges();
            return newTicket;
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

            if (movie.Screenings != null)
            {
                IEnumerable<Screening> screenings = from screening in movie.Screenings where movie.Id == movie.Id select screening;

                // _dbContext.Screenings.Select(s => s.MovieId == movie.Id);
                _dbContext.Remove(screenings);
            }

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
                                UpdatedAt = movie.UpdatedAt,
                                Screenings = movie.Screenings.Select(x => new ScreeningDTO()
                                {
                                    Id = x.Id,
                                    ScreenNumber = x.ScreenNumber,
                                    Capacity = x.Capacity,
                                    StartsAt = x.StartsAt,
                                    CreatedAt = x.CreatedAt,
                                    UpdatedAt = x.UpdatedAt
                                })
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

        public async Task<IEnumerable<TicketDTO>> GetTickets(int customerId, int ScreeningId)
        {
            var tickets = from ticket in _dbContext.Tickets
                             where ticket.CustomerId == customerId && ticket.ScreeningId == ScreeningId
                             select new TicketDTO()
                             {
                                 Id = ticket.Id,
                                 NumSeats = ticket.NumSeats,
                                 CustomerId = ticket.CustomerId,
                                 ScreeningId = ticket.ScreeningId
                             };
            return await tickets.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(CustomerPut customer, int id)
        {
            var updatedCustomer = _dbContext.Customers.Single(c => c.Id == id);

            //core, replaced by extension now
            /*
            Customer updatedCustomer = new Customer()
            {
                Id = id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                UpdatedAt = DateTime.UtcNow
            };*/


            // extension: only update fields that are provided
            _dbContext.Attach(updatedCustomer);
            if (!string.IsNullOrEmpty(customer.Name) && !(customer.Name == "string"))
            {
                updatedCustomer.Name = customer.Name;
            }

            if (!string.IsNullOrEmpty(customer.Email) && !(customer.Email == "string"))
            {
                updatedCustomer.Email = customer.Email;
            }
            if (!string.IsNullOrEmpty(customer.Phone) && !(customer.Phone == "string"))
            {
                updatedCustomer.Phone = customer.Phone;
            }
            updatedCustomer.UpdatedAt = DateTime.UtcNow;

           // _dbContext.Entry(oldCustomer).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return updatedCustomer;
        }

        public async Task<Movie> UpdateMovie(MoviePut movie, int id)
        {
            var updatedMovie = _dbContext.Movies.Single(c => c.Id == id);

            // Core, replaced by extension
            /*
            Movie updated = new Movie()
            {
                Id = id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                UpdatedAt = DateTime.UtcNow
            }; */

            // extension, only update fields that are provided
            _dbContext.Attach(updatedMovie);
            if (!string.IsNullOrEmpty(updatedMovie.Title) && !(movie.Title == "string"))
            {
                updatedMovie.Title = movie.Title;
            }

            if (!string.IsNullOrEmpty(updatedMovie.Rating) && !(movie.Rating == "string"))
            {
                updatedMovie.Rating = movie.Rating;
            }
            if (!string.IsNullOrEmpty(updatedMovie.Description) && !(movie.Description == "string"))
            {
                updatedMovie.Description = movie.Description;
            }
            if (movie.RuntimeMins != 0)
            {
                updatedMovie.RuntimeMins = movie.RuntimeMins;
            }

            updatedMovie.UpdatedAt = DateTime.UtcNow;
            _dbContext.SaveChanges();

            return updatedMovie;
        }
    }
}
