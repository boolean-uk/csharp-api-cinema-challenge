using api_cinema_challenge.DTOs;
using api_cinema_challenge.DTOs.Customer;
using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.DTOs.Screening;
using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", AddCustomer);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customer/{id}", DeleteCustomer);

            app.MapGet("/movies", GetMovies);
            app.MapPost("/movies/", AddMovie);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);

            app.MapGet("/movies/{id}/screenings", GetScreenings);
            app.MapPost("/movies/{id}/screenings", AddScreening);

            app.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);
            app.MapPost("/customers/{customerId}/screenings/{screeningId}", AddTicket);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddCustomer(IRepository<Customer> custRepo, CustomerPostModel model)
        {
            var customers = await custRepo.GetAll();
            if (customers.Any(x => x.Name == model.Name))
            {
                return TypedResults.BadRequest("Customer already exists");
            }

            Customer customer = new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone, UpdatedAt = DateTime.UtcNow };

            var newCustomer = await custRepo.Create(customer);
            Payload<Customer> payload = new Payload<Customer> { Data = newCustomer };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> custRepo)
        {
            var customer = await custRepo.GetAll();
            Payload<List<Customer>> payload = new Payload<List<Customer>>() { Data = customer.ToList() };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> custRepo, int id, CustomerPutModel model)
        {
            try
            {
                var customers = await custRepo.GetAll();
                var entity = customers.FirstOrDefault(c => c.Id == id);

                if (entity != null)
                {
                    entity.Name = !string.IsNullOrEmpty(model.Name) ? model.Name : entity.Name;
                    entity.Email = !string.IsNullOrEmpty(model.Email) ? model.Email : entity.Email;
                    entity.Phone = !string.IsNullOrEmpty(model.Phone) ? model.Phone : entity.Phone;
                    entity.UpdatedAt = DateTime.UtcNow;
                    var result = await custRepo.Update(entity);

                    Payload<Customer> payload = new Payload<Customer>() { Data = result };
                    return TypedResults.Ok(payload);
                }
                else return Results.NotFound("Customer does not exist");
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> custRepo, int id)
        {
            try
            {
                var deletedCustomer = await custRepo.Delete(id);

                if (deletedCustomer != null)
                {
                    Payload<Customer> payload = new Payload<Customer>() { Data = deletedCustomer };
                    return TypedResults.Ok(payload);
                }
                return TypedResults.NotFound("Customer does not exist");
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> movieRepo)
        {
            var movies = await movieRepo.GetAll();
            Payload<List<Movie>> payload = new Payload<List<Movie>>() { Data = movies.ToList() };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddMovie(IRepository<Movie> movieRepo, IRepository<Screening> screenRepo, MoviePostModel model)
        {
            var movies = await movieRepo.GetAll();

            if (movies.Any(x => x.Title == model.Title))
            {
                return TypedResults.BadRequest("Movie already exists");
            }
            else
            {

                Movie movie = new Movie()
                {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description,
                    RuntimeMins = model.RuntimeMins,
                    UpdatedAt = DateTime.UtcNow
                };

                var newMovie = await movieRepo.Create(movie);

                if (model.Screenings != null)
                {
                    foreach (ScreeningPostModel s in model.Screenings)
                    {
                        Screening screening = new Screening()
                        {
                            MovieId = newMovie.Id,
                            ScreenNumber = s.ScreenNumber,
                            Capacity = s.Capacity,
                            StartsAt = DateTime.Parse(s.StartsAt).ToUniversalTime().AddHours(2),
                            UpdatedAt = DateTime.UtcNow
                        };

                        var newScreening = await screenRepo.Create(screening);
                    }
                }


                Payload<Movie> payload = new Payload<Movie> { Data = newMovie };
                return TypedResults.Ok(payload);
            }


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> movieRepo, int id, MoviePutModel model)
        {
            try
            {
                
                var entity = await movieRepo.GetById(id);

                if (entity != null)
                {
                    entity.Title = !string.IsNullOrEmpty(model.Title) ? model.Title : entity.Title;
                    entity.Rating = !string.IsNullOrEmpty(model.Rating) ? model.Rating : entity.Rating;
                    entity.Description = !string.IsNullOrEmpty(model.Description) ? model.Description : entity.Description;
                    entity.RuntimeMins = !string.IsNullOrEmpty(model.RuntimeMins.ToString()) ? model.RuntimeMins : entity.RuntimeMins;
                    entity.UpdatedAt = DateTime.UtcNow;
                    var result = await movieRepo.Update(entity);

                    Payload<Movie> payload = new Payload<Movie>() { Data = result };
                    return TypedResults.Ok(payload);
                }
                else return Results.NotFound("Movie does not exist");
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> movieRepo, int id)
        {
            try
            {
                var deletedMovie = await movieRepo.Delete(id);

                if (deletedMovie != null)
                {
                    Payload<Movie> payload = new Payload<Movie>() { Data = deletedMovie };
                    return TypedResults.Ok(payload);
                }
                return TypedResults.NotFound("Movie does not exist");
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> screeningRepo, int id)
        {
            var screenings = await screeningRepo.GetAll();
            if (!screenings.Any(m => m.MovieId == id))
            {
                return TypedResults.NotFound("This movie id matches no screenings");
            }

            var movieScreenings = screenings.Where(x => x.MovieId == id);
            Payload<List<Screening>> payload = new Payload<List<Screening>>() { Data = movieScreenings.ToList() };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddScreening(IRepository<Screening> screeningRepo, IRepository<Movie> movieRepo, int id, ScreeningPostModel model)
        {
            var movies = await movieRepo.GetAll();
            var screenings = await screeningRepo.GetAll();

            if (!movies.Any(m => m.Id == id))
            {
                return TypedResults.NotFound("Movie doesn't exist");
            }

            if (screenings.Any(s => s.ScreenNumber == model.ScreenNumber && s.StartsAt == DateTime.Parse(model.StartsAt).ToUniversalTime().AddHours(2)))
            {
                return TypedResults.BadRequest("A screening already exists for this screen at given time.");
            }

            Screening screening = new Screening()
            {
                MovieId = id,
                ScreenNumber = model.ScreenNumber,
                Capacity = model.Capacity,
                StartsAt = DateTime.Parse(model.StartsAt).ToUniversalTime().AddHours(2),
                UpdatedAt = DateTime.UtcNow
            };

            var newScreening = await screeningRepo.Create(screening);
            Payload<Screening> payload = new Payload<Screening> { Data = newScreening };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> ticketRepo, IRepository<Customer> custRepo, IRepository<Screening> screeningRepo, int customerId, int screeningId)
        {
            var tickets = await ticketRepo.GetAll();

            if (!tickets.Any(x => x.CustomerId == customerId && x.ScreeningId == screeningId))
            {
                return TypedResults.NotFound("No tickets matches given customer and screening");
            }

            var customertickets = tickets.Where(x => x.CustomerId == customerId && x.ScreeningId == screeningId);
            Payload<List<Ticket>> payload = new Payload<List<Ticket>>() { Data = customertickets.ToList() };
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddTicket(IRepository<Ticket> ticketRepo, IRepository<Customer> custRepo, IRepository<Screening> screeningRepo, int customerId, int screeningId, TicketPostModel model)
        {
            
            var checkCustomer = await custRepo.GetById(customerId);
            var checkScreening = await screeningRepo.GetById(screeningId);

            if (checkCustomer == null)
            {
                return TypedResults.NotFound("Customer doesn't exist");
            }

            if (checkScreening == null)
            {
                return TypedResults.NotFound("Screening doesn't exist");
            }

            
            Ticket ticket = new Ticket()
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                NumSeats = model.NumSeats,
                UpdatedAt = DateTime.UtcNow
            };

            var newTicket = await ticketRepo.Create(ticket);
            Payload<Ticket> payload = new Payload<Ticket>() { Data = newTicket };
            return TypedResults.Ok(payload);
        }

    }
}
