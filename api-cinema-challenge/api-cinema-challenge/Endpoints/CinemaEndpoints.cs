using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

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
        public static async Task<IResult> CreateCustomer(IRepository<Customer> customerRepository, string name, string email, string phone)
        {
            var customer = new Customer
            {
                Name = name,
                Email = email,
                Phone = phone
            };

            var createdCustomer = await customerRepository.Insert(customer);
            return TypedResults.Created($"/customers/{createdCustomer.Id}", new { status = "success", data = createdCustomer });
        }

        public static async Task<IResult> GetCustomers(IRepository<Customer> customerRepository)
        {
            var customers = await customerRepository.Get();
            return TypedResults.Ok(new { status = "success", data = customers });
        }

        public static async Task<IResult> GetCustomerById(IRepository<Customer> customerRepository, int id)
        {
            var customer = await customerRepository.GetById(id);
            if (customer == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Customer not found" });
            }
            return TypedResults.Ok(new { status = "success", data = customer });
        }

        public static async Task<IResult> UpdateCustomer(IRepository<Customer> customerRepository, int id, string? name, string? email, string? phone)
        {
            var customer = await customerRepository.GetById(id);
            if (customer == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Customer not found" });
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
                return TypedResults.Ok(new { status = "success", data = updatedCustomer });
            }

            return TypedResults.Ok(new { status = "failure", message = "No changes made to the customer" });
        }

        public static async Task<IResult> DeleteCustomer(IRepository<Customer> customerRepository, int id)
        {
            var customer = await customerRepository.GetById(id);
            if (customer == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Customer not found" });
            }
            var deletedCustomer = await customerRepository.Delete(id);
            return TypedResults.Ok(new { status = "success", data = deletedCustomer });
        }
        #endregion

        #region movie
        public static async Task<IResult> CreateMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, string title, string rating, string description, int runtimeMins, List<Screening>? screenings)
        {
            var movie = new Movie
            {
                Title = title,
                Rating = decimal.Parse(rating),
                Description = description,
                RuntimeMins = runtimeMins
            };

            var createdMovie = await movieRepository.Insert(movie);

            if (screenings != null && screenings.Any())
            {
                foreach (var screening in screenings)
                {
                    screening.MovieId = createdMovie.Id;
                    await screeningRepository.Insert(screening);
                }
            }

            return TypedResults.Created($"/movies/{createdMovie.Id}", new { status = "success", data = createdMovie });
        }

        public static async Task<IResult> GetMovies(IRepository<Movie> movieRepository)
        {
            var movies = await movieRepository.Get();
            return TypedResults.Ok(new { status = "success", data = movies });
        }

        public static async Task<IResult> GetMovieById(IRepository<Movie> movieRepository, int id)
        {
            var movie = await movieRepository.GetById(id);
            if (movie == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Movie not found" });
            }
            return TypedResults.Ok(movie);
        }

        public static async Task<IResult> UpdateMovie(IRepository<Movie> movieRepository, int id, string? title, string? rating, string? description, int? runtimeMins)
        {
            var movie = await movieRepository.GetById(id);
            if (movie == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Movie not found" });
            }

            bool isUpdated = false;

            if (!string.IsNullOrEmpty(title) && title != movie.Title)
            {
                movie.Title = title;
                isUpdated = true;
            }

            if (!string.IsNullOrEmpty(rating) && rating != movie.Rating.ToString())
            {
                movie.Rating = decimal.Parse(rating);
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
                return TypedResults.Ok(new { status = "success", data = updatedMovie });
            }

            return TypedResults.Ok(new { status = "failure", message = "No changes made to the movie" });
        }

        public static async Task<IResult> DeleteMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, int id)
        {
            var movie = await movieRepository.GetById(id);
            if (movie == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Movie not found" });
            }

            var screenings = await screeningRepository.Get();
            screenings = screenings.Where(s => s.MovieId == id).ToList();

            foreach (var screening in screenings)
            {
                await screeningRepository.Delete(screening.Id);
            }

            var deletedMovie = await movieRepository.Delete(id);
            return TypedResults.Ok(new { status = "success", data = deletedMovie });
        }
        #endregion

        #region screening
        public static async Task<IResult> CreateScreening(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, int id, int screenNumber, int capacity, string startsAt)
        {
            var movie = await movieRepository.GetById(id);
            if (movie == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Movie not found" });
            }

            if (!DateTime.TryParse(startsAt, out var parsedStartsAt))
            {
                return TypedResults.BadRequest(new { status = "failure", message = "Invalid DateTime format for 'startsAt'. Use format 'yyyy-mm-dd hh:mm:ss'" });
            }

            var screening = new Screening
            {
                MovieId = id,
                ScreenNumber = screenNumber,
                Capacity = capacity,
                StartsAt = parsedStartsAt
            };

            var createdScreening = await screeningRepository.Insert(screening);

            return TypedResults.Created($"/movies/{id}/screenings/{createdScreening.Id}", new
            {
                status = "success",
                data = createdScreening
            });
        }

        public static async Task<IResult> GetScreenings(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, int id)
        {
            var movie = await movieRepository.GetById(id);
            if (movie == null)
            {
                return TypedResults.NotFound(new { status = "failure", message = "Movie not found" });
            }

            var screenings = await screeningRepository.Get();
            var movieScreenings = screenings.Where(s => s.MovieId == id).ToList();

            return TypedResults.Ok(new
            {
                status = "success",
                data = movieScreenings
            });
        }
        #endregion

        #region ticket
        public static async Task<IResult> BookTicket(
            IRepository<Customer> customerRepository,
            IRepository<Screening> screeningRepository,
            IRepository<Ticket> ticketRepository,
            int customerId,
            int screeningId,
            int numSeats)
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

            var totalBookedSeats = screening.Tickets.Sum(t => t.NumSeats);
            if (totalBookedSeats + numSeats > screening.Capacity)
            {
                return TypedResults.BadRequest(new { status = "failure", message = "Not enough seats available" });
            }

            var ticket = new Ticket
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                NumSeats = numSeats
            };

            var createdTicket = await ticketRepository.Insert(ticket);

            return TypedResults.Created($"/customers/{customerId}/screenings/{screeningId}/tickets/{createdTicket.Id}", new
            {
                status = "success",
                data = createdTicket
            });
        }

        public static async Task<IResult> GetTickets(
            IRepository<Customer> customerRepository,
            IRepository<Screening> screeningRepository,
            IRepository<Ticket> ticketRepository,
            int customerId,
            int screeningId)
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

            return TypedResults.Ok(new
            {
                status = "success",
                data = tickets
            });
        }
        #endregion

    }
}
