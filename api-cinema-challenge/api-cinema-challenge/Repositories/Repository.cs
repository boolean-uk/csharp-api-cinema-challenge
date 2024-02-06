using api_cinema_challenge.Data;
using api_cinema_challenge.DTOS;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class Repository : IRepository
    {
        private CinemaContext _cinemaContext;
        public Repository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<CreateCustomerDTO> CreateCustomer(CreateCustomerDTO createCustomerDTO)
        {
            var newCustomer = new Customer
            {
                Name = createCustomerDTO.Name,
                Email = createCustomerDTO.Email,
                Phone = createCustomerDTO.Phone
               
            };

            _cinemaContext.Customers.Add(newCustomer);
            await _cinemaContext.SaveChangesAsync();

            var customerDTO = new CreateCustomerDTO
            {
               
                Name = newCustomer.Name,
                Email = newCustomer.Email,
                Phone = newCustomer.Phone
            };

            return customerDTO;
        

    }
        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            var customer = await _cinemaContext.Customers.ToListAsync();


            var customerDTO = customer.Select(p => new CustomerDTO
            {
               Id = p.Id,
               Name = p.Name,
               Email = p.Email,
               Phone = p.Phone,
            });
            return customerDTO;
        }
        public async Task<CreateCustomerDTO> UpdateCustomer(CreateCustomerDTO updateCustomerDTO, int id)
        {
            var existingCustomer = await _cinemaContext.Customers.FindAsync(id);

            if (existingCustomer == null)
            {
                
                return null;
            }

            
            existingCustomer.Name = updateCustomerDTO.Name;
            existingCustomer.Email = updateCustomerDTO.Email;
            existingCustomer.Phone = updateCustomerDTO.Phone;
            

            await _cinemaContext.SaveChangesAsync();

           
            var updatedCustomerDTO = new CreateCustomerDTO
            {
                
                Name = existingCustomer.Name,
                Email = existingCustomer.Email,
                Phone = existingCustomer.Phone
            };

            return updatedCustomerDTO;
        }

        public async Task<CustomerDTO> DeleteCustomer(int id)
        {
           var customerToDelete = await _cinemaContext.Customers.FindAsync(id);

            if (customerToDelete == null)
            {
                
                return null;
            }

            _cinemaContext.Customers.Remove(customerToDelete);
            await _cinemaContext.SaveChangesAsync();

          
            var deletedCustomerDTO = new CustomerDTO
            {
                Id = customerToDelete.Id,
                Name = customerToDelete.Name,
                Email = customerToDelete.Email,
                Phone = customerToDelete.Phone
            };

            return deletedCustomerDTO;
        }

        public async Task<CreateMovieDTO> CreateMovie(CreateMovieDTO createMovieDTO)
        {
            var newMovie = new Movie
            {
                          
                Title = createMovieDTO.Title,
                Rating = createMovieDTO.Rating,
                Description = createMovieDTO.Description,
                RuntimeMins = createMovieDTO.RuntimeMins,

            };

            _cinemaContext.Movies.Add(newMovie);
            await _cinemaContext.SaveChangesAsync();

            var MovieDTO = new CreateMovieDTO
            {

                Title = newMovie.Title,
                Rating = newMovie.Rating,
                Description = newMovie.Description,
                RuntimeMins = newMovie.RuntimeMins,

            };

            return MovieDTO;
        }
        public async Task<IEnumerable<MovieDTO>> GetMovies()
        {
            var movie = await _cinemaContext.Movies.ToListAsync();


            var movieDTO = movie.Select(p => new MovieDTO
            {
                Id = p.Id,
                Title = p.Title,
                Rating = p.Rating,
                Description = p.Description,
                RuntimeMins = p.RuntimeMins,
            });
            return movieDTO;
        }


        public async Task<CreateMovieDTO> UpdateMovie(CreateMovieDTO updateMovieDTO, int id)
        {
            var existingMovie = await _cinemaContext.Movies.FindAsync(id);

            if (existingMovie == null)
            {

                return null;
            }


            existingMovie.Title = updateMovieDTO.Title;
            existingMovie.Rating = updateMovieDTO.Rating;
            existingMovie.Description = updateMovieDTO.Description;
            existingMovie.RuntimeMins = updateMovieDTO.RuntimeMins;


            await _cinemaContext.SaveChangesAsync();


            var updatedMovieDTO = new CreateMovieDTO
            {
                
                Title = existingMovie.Title,
                Rating = existingMovie.Rating,
                Description = existingMovie.Description,
                RuntimeMins = existingMovie.RuntimeMins,
            };

            return updatedMovieDTO;
        }

        public async Task<MovieDTO> DeleteMovie(int id)
        {
            var movieToDelete = await _cinemaContext.Movies.FindAsync(id);

            if (movieToDelete == null)
            {
                
                return null;
            }

            _cinemaContext.Movies.Remove(movieToDelete);
            await _cinemaContext.SaveChangesAsync();

            // Map Entity to DTO 
            var deletedMovieDTO = new MovieDTO
            {
                Id = movieToDelete.Id,
                Title = movieToDelete.Title,
                Rating = movieToDelete.Rating,
                Description = movieToDelete.Description,
                RuntimeMins = movieToDelete.RuntimeMins,
            };

            return deletedMovieDTO;
        }

        public async Task<CreateScreeningDTO> CreateScreening(CreateScreeningDTO createScreeningDTO)
        {
            var movie = await _cinemaContext.Movies.FindAsync(createScreeningDTO.MovieId);

            if (movie == null)
            {
                
                return null;
            }

            var newScreening = new Screening
            {
             
                MovieId = createScreeningDTO.MovieId,
                ScreenNumber = createScreeningDTO.ScreenNumber,
                Capacity = createScreeningDTO.Capacity,
                StartsAt = createScreeningDTO.StartsAt,
                CreatedAt = createScreeningDTO.CreatedAt,
                UpdatedAt = createScreeningDTO.UpdatedAt,
            };

            _cinemaContext.Screenings.Add(newScreening);
            await _cinemaContext.SaveChangesAsync();

            var createdScreeningDTO = new CreateScreeningDTO
            {
                
                MovieId = newScreening.MovieId,
                ScreenNumber = newScreening.ScreenNumber,
                Capacity = newScreening.Capacity,
                StartsAt = newScreening.StartsAt,
                CreatedAt = newScreening.CreatedAt,
                UpdatedAt = newScreening.UpdatedAt,
                
            };

            return createdScreeningDTO;
        }

        public async Task<IEnumerable<ScreeningDTO>> GetScreeningsById(int movieId)
        {
            var movie = await _cinemaContext.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(t => t.Id == movieId);

            if (movie == null)
            {
                
                return null; 
            }

            var screeningDTOs = movie.Screenings.Select(screening => new ScreeningDTO
            {
                Id = screening.Id,
                MovieId = screening.MovieId,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt= screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt,
            
            });

            return screeningDTOs;
        }

        public async Task<TicketDTO> GetTicketById(int customerId, int screeningId)
        {
            var ticket = await _cinemaContext.Tickets.FirstOrDefaultAsync(t => t.CustomerId == customerId && t.ScreeningId == screeningId);

            if (ticket == null)
            {
                return null;
            }

            var ticketDTO = new TicketDTO
            {
                CustomerId = ticket.CustomerId,
                ScreeningId = ticket.ScreeningId,
                NumSeats = ticket.numSeats,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt
            };

            return ticketDTO;
        }
        public async Task<TicketDTO> CreateTicket(CreateTicketDTO createTicketDTO)
        {
            var newTicket = new Ticket
            {
                CustomerId = createTicketDTO.CustomerId,
                ScreeningId = createTicketDTO.ScreeningId,
                numSeats = createTicketDTO.NumSeats,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime()
            };

            _cinemaContext.Tickets.Add(newTicket);
            await _cinemaContext.SaveChangesAsync();

            var createdTicketDTO = new TicketDTO
            {
                CustomerId = newTicket.CustomerId,
                ScreeningId = newTicket.ScreeningId,
                NumSeats = newTicket.numSeats,
                CreatedAt = newTicket.CreatedAt,
                UpdatedAt = newTicket.UpdatedAt
            };

            return createdTicketDTO;
        }
    }
}



