using System.Text.RegularExpressions;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {
        public static void ConfigureCinemaEndpoints(this WebApplication app)
        {
            var customersGroup = app.MapGroup("customers");
            var moviesGroup = app.MapGroup("movies");

            customersGroup.MapPost("/", CreateCustomer);
            customersGroup.MapGet("/", GetCustomers);
            customersGroup.MapGet("/{id}", GetCustomerById);
            customersGroup.MapPut("/{id}", UpdateCustomer);
            customersGroup.MapDelete("/{id}", DeleteCustomer);
            customersGroup.MapPost("/{customerId}/screenings/{screeningId}", BookTicket);
            customersGroup.MapGet("/{customerId}/screenings/{screeningId}", GetTickets);

            moviesGroup.MapPost("/", CreateMovie);
            moviesGroup.MapGet("/", GetMovies);
            moviesGroup.MapGet("/{id}", GetMovieById);
            moviesGroup.MapPut("/{id}", UpdateMovie);
            moviesGroup.MapDelete("/{id}", DeleteMovie);
            moviesGroup.MapPost("/{id}/screenings", CreateScreening);
            moviesGroup.MapGet("/{id}/screenings", GetScreenings);
        }

        #region customer
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateCustomer(
            IRepository<Customer> customerRepository,
            IMapper mapper,
            string name,
            string email,
            string phone
            )
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Name cannot be null or empty." });
                }

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Invalid email address." });
                }

                if (string.IsNullOrWhiteSpace(phone) || !Regex.IsMatch(phone, @"^\+?\d{7,15}$"))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Phone number must be between 7 and 15 digits and not contain any letters or symbols except '+'." });
                }

                var customer = new Customer
                {
                    Name = name,
                    Email = email,
                    Phone = phone
                };

                var createdCustomer = await customerRepository.Insert(customer);
                var customerDto = mapper.Map<CustomerDTO>(createdCustomer);

                return TypedResults.Created($"/customers/{customerDto.Id}", new { status = "success", data = customerDto });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetCustomers(
            IRepository<Customer> customerRepository,
            IMapper mapper
            )
        {
            try
            {
                var customers = await customerRepository.Get();
                var customersDtos = mapper.Map<List<CustomerDTO>>(customers);
                return TypedResults.Ok(new { status = "success", data = customersDtos });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetCustomerById(
            IRepository<Customer> customerRepository,
            IMapper mapper,
            int id
            )
        {
            try
            {
                var customer = await customerRepository.GetById(id);
                if (customer == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Customer not found." });
                }

                var customerDto = mapper.Map<CustomerDTO>(customer);
                return TypedResults.Ok(new { status = "success", data = customerDto });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> UpdateCustomer(
            IRepository<Customer> customerRepository,
            IMapper mapper,
            int id,
            string? name,
            string? email,
            string? phone
            )
        {
            try
            {
                var customer = await customerRepository.GetById(id);
                if (customer == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Customer not found." });
                }

                bool isUpdated = false;

                if (!string.IsNullOrEmpty(name) && name != customer.Name)
                {
                    customer.Name = name;
                    isUpdated = true;
                }

                if (!string.IsNullOrEmpty(email) && email != customer.Email)
                {
                    customer.Email = email;
                    isUpdated = true;
                }

                if (!string.IsNullOrEmpty(phone) && phone != customer.Phone)
                {
                    customer.Phone = phone;
                    isUpdated = true;
                }

                if (isUpdated)
                {
                    customer.UpdatedAt = DateTime.UtcNow;
                    var updatedCustomer = await customerRepository.Update(customer);
                    var customerDto = mapper.Map<CustomerDTO>(updatedCustomer);
                    return TypedResults.Ok(new { status = "success", data = customerDto });
                }

                return TypedResults.BadRequest(new { status = "failure", message = "No changes made to the customer." });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteCustomer(
            IRepository<Customer> customerRepository,
            IMapper mapper,
            int id
        )
        {
            try
            {
                var customer = await customerRepository.GetById(id);
                if (customer == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Customer not found." });
                }

                var deletedCustomer = await customerRepository.Delete(id);
                var customerDto = mapper.Map<CustomerDTO>(deletedCustomer);

                return TypedResults.Ok(new { status = "success", data = customerDto });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }
        #endregion

        #region movie
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateMovie(
            IRepository<Movie> movieRepository,
            IRepository<Screening> screeningRepository,
            IMapper mapper,
            string title,
            string rating,
            string description,
            int runtimeMins,
            List<ScreeningDTO>? screenings
        )
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Title cannot be null or empty." });
                }

                if (string.IsNullOrWhiteSpace(rating) || !Regex.IsMatch(rating, @"^[A-Za-z0-9]+$"))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Rating is required and must be alphanumeric." });
                }

                if (string.IsNullOrWhiteSpace(description))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Description cannot be null or empty." });
                }

                if (runtimeMins <= 0)
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Runtime minutes must be a positive integer." });
                }

                var movie = new Movie
                {
                    Title = title,
                    Rating = rating,
                    Description = description,
                    RuntimeMins = runtimeMins
                };

                var createdMovie = await movieRepository.Insert(movie);

                if (screenings != null && screenings.Any())
                {
                    foreach (var screeningDto in screenings)
                    {
                        var screening = mapper.Map<Screening>(screeningDto);
                        screening.MovieId = createdMovie.Id;
                        await screeningRepository.Insert(screening);
                    }
                }

                var movieDto = mapper.Map<MovieDTO>(createdMovie);
                return TypedResults.Created($"/movies/{movieDto.Id}", new { status = "success", data = movieDto });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetMovies(
            IRepository<Movie> movieRepository,
            IMapper mapper
        )
        {
            try
            {
                var movies = await movieRepository.Get();
                var moviesDtos = mapper.Map<List<MovieDTO>>(movies);
                return TypedResults.Ok(new { status = "success", data = moviesDtos });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetMovieById(
            IRepository<Movie> movieRepository,
            IMapper mapper,
            int id
        )
        {
            try
            {
                var movie = await movieRepository.GetById(id);
                if (movie == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Movie not found." });
                }

                var movieDto = mapper.Map<MovieDTO>(movie);
                return TypedResults.Ok(new { status = "success", data = movieDto });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> UpdateMovie(
            IRepository<Movie> movieRepository,
            IMapper mapper,
            int id,
            string? title,
            string? rating,
            string? description,
            int? runtimeMins
        )
        {
            try
            {
                var movie = await movieRepository.GetById(id);
                if (movie == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Movie not found." });
                }

                bool isUpdated = false;

                if (!string.IsNullOrEmpty(title) && title != movie.Title)
                {
                    movie.Title = title;
                    isUpdated = true;
                }

                if (!string.IsNullOrEmpty(rating) && rating != movie.Rating)
                {
                    movie.Rating = rating;
                    isUpdated = true;
                }

                if (!string.IsNullOrEmpty(description) && description != movie.Description)
                {
                    movie.Description = description;
                    isUpdated = true;
                }

                if (runtimeMins.HasValue && runtimeMins != movie.RuntimeMins)
                {
                    movie.RuntimeMins = runtimeMins.Value;
                    isUpdated = true;
                }

                if (isUpdated)
                {
                    movie.UpdatedAt = DateTime.UtcNow;
                    var updatedMovie = await movieRepository.Update(movie);
                    var movieDto = mapper.Map<MovieDTO>(updatedMovie);
                    return TypedResults.Ok(new { status = "success", data = movieDto });
                }

                return TypedResults.BadRequest(new { status = "failure", message = "No changes made to the movie." });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteMovie(
            IRepository<Movie> movieRepository,
            IRepository<Screening> screeningRepository,
            IMapper mapper,
            int id
        )
        {
            try
            {
                var movie = await movieRepository.GetById(id);
                if (movie == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Movie not found." });
                }

                var screenings = await screeningRepository.Get();
                screenings = screenings.Where(s => s.MovieId == id).ToList();

                foreach (var screening in screenings)
                {
                    await screeningRepository.Delete(screening.Id);
                }

                var deletedMovie = await movieRepository.Delete(id);
                var movieDto = mapper.Map<MovieDTO>(deletedMovie);
                return TypedResults.Ok(new { status = "success", data = movieDto });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }
        #endregion

        #region screening
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateScreening(
            IRepository<Movie> movieRepository,
            IRepository<Screening> screeningRepository,
            IMapper mapper,
            int id,
            int screenNumber,
            int capacity,
            string startsAt
        )
        {
            try
            {
                var movie = await movieRepository.GetById(id);
                if (movie == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Movie not found" });
                }

                if (screenNumber <= 0)
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Screen number must be a positive integer." });
                }

                if (capacity <= 0)
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Capacity must be a positive integer." });
                }

                if (!DateTime.TryParse(startsAt, out var parsedStartsAt))
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Invalid DateTime format for 'startsAt'. Use format 'yyyy-mm-dd hh:mm:ss'." });
                }

                if (parsedStartsAt.Kind == DateTimeKind.Local)
                {
                    parsedStartsAt = parsedStartsAt.ToUniversalTime();
                }
                else if (parsedStartsAt.Kind == DateTimeKind.Unspecified)
                {
                    parsedStartsAt = DateTime.SpecifyKind(parsedStartsAt, DateTimeKind.Utc);
                }

                var screening = new Screening
                {
                    MovieId = id,
                    ScreenNumber = screenNumber,
                    Capacity = capacity,
                    StartsAt = parsedStartsAt
                };

                var createdScreening = await screeningRepository.Insert(screening);
                var screeningDto = mapper.Map<ScreeningDTO>(createdScreening);

                return TypedResults.Created($"/movies/{id}/screenings/{screeningDto.Id}", new
                {
                    status = "success",
                    data = screeningDto
                });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreenings(
            IRepository<Movie> movieRepository,
            IRepository<Screening> screeningRepository,
            IMapper mapper,
            int id
        )
        {
            try
            {
                var movie = await movieRepository.GetById(id);
                if (movie == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Movie not found." });
                }

                var screenings = await screeningRepository.Get();
                var movieScreenings = screenings.Where(s => s.MovieId == id).ToList();
                var screeningsDtos = mapper.Map<List<ScreeningDTO>>(movieScreenings);

                return TypedResults.Ok(new
                {
                    status = "success",
                    data = screeningsDtos
                });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }
        #endregion

        #region ticket
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> BookTicket(
            IRepository<Customer> customerRepository,
            IRepository<Screening> screeningRepository,
            IRepository<Ticket> ticketRepository,
            IMapper mapper,
            int customerId,
            int screeningId,
            int numSeats
        )
        {
            try
            {
                var customer = await customerRepository.GetById(customerId);
                if (customer == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Customer not found." });
                }

                var screening = await screeningRepository.GetById(screeningId);
                if (screening == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Screening not found." });
                }

                if (numSeats <= 0)
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Number of seats must be a positive integer." });
                }

                var totalBookedSeats = screening.Tickets.Sum(t => t.NumSeats);
                if (totalBookedSeats + numSeats > screening.Capacity)
                {
                    return TypedResults.BadRequest(new { status = "failure", message = "Not enough seats available." });
                }

                var ticket = new Ticket
                {
                    CustomerId = customerId,
                    ScreeningId = screeningId,
                    NumSeats = numSeats
                };

                var createdTicket = await ticketRepository.Insert(ticket);
                var ticketDto = mapper.Map<TicketDTO>(createdTicket);

                return TypedResults.Created($"/customers/{customerId}/screenings/{screeningId}/tickets/{ticketDto.Id}", new
                {
                    status = "success",
                    data = ticketDto
                });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetTickets(
            IRepository<Customer> customerRepository,
            IRepository<Screening> screeningRepository,
            IRepository<Ticket> ticketRepository,
            IMapper mapper,
            int customerId,
            int screeningId
        )
        {
            try
            {
                var customer = await customerRepository.GetById(customerId);
                if (customer == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Customer not found" });
                }

                var screening = await screeningRepository.GetById(screeningId);
                if (screening == null)
                {
                    return TypedResults.NotFound(new { status = "failure", message = "Screening not found" });
                }

                var tickets = await ticketRepository.Get();
                tickets = tickets.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId);
                var ticketsDtos = mapper.Map<List<TicketDTO>>(tickets);

                return TypedResults.Ok(new
                {
                    status = "success",
                    data = ticketsDtos
                });
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(new { status = "failure", message = "An unexpected error occurred.", details = ex.Message });
            }
        }
        #endregion
    }
}
