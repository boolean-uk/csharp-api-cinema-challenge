using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Payloads;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoints(this IEndpointRouteBuilder app)
        {
            //Customer
            app.MapGet("/cinema/customers", GetAllCustomers);
            app.MapGet("/cinema/customers/{id}", GetCustomer);
            app.MapPost("/cinema/customers", AddCustomer);
            app.MapPut("/cinema/customers/{id}", UpdateCustomer);
            app.MapDelete("/cinema/customers/{id}", DeleteCustomer);
            //Movie
            app.MapGet("/cinema/movies", GetAllMovies);
            app.MapPost("/cinema/movies", AddMovie);
            app.MapPut("/cinema/movies/{id}", UpdateMovie);
            app.MapDelete("/cinema/movies/{id}", DeleteMovie);
            //Screening
            app.MapGet("/cinema/movies/{id}/screenings", GetAllScreenings);
            app.MapPost("/cinema/movies/{id}/screenings", CreateScreening);
            //Ticket
            app.MapGet("/cinema/customers/{customerId}/tickets", GetAllTicketsForCustomer);
            app.MapPost("/cinema/customers/{customerId}/tickets", CreateTicket);
        }


        // Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            var customers = await repository.GetAllCustomers();
            if (customers == null || customers.Count == 0)
            {
                return TypedResults.NotFound("No customers have been added to the database!");
            }
            else
            {
                var customersDTO = customers.Select(c => new CustomerResponseDTO(c)).ToList();
                return TypedResults.Ok(customersDTO);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomer(IRepository repository, int id)
        {
            var customer = await repository.GetCustomerById(id);
            if (customer == null)
            {
                return TypedResults.NotFound("Customer not found!");
            }
            return TypedResults.Ok(new CustomerResponseDTO(customer));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddCustomer(IRepository repository, CreateCustomerPayload payload)
        {
            var customer = new Customer
            {
                Name = payload.Name,
                Email = payload.Email,
                Phone = payload.Phone
            };
            var addedCustomer = await repository.AddCustomer(customer);
            return TypedResults.Created($"Customer {addedCustomer.Name} created successfully.");
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, UpdateCustomerPayload payload)
        {
            var customer = await repository.GetCustomerById(id);
            if (customer == null)
            {
                return TypedResults.NotFound("Customer not found");
            }

            customer.Name = payload.Name;
            customer.Email = payload.Email;
            customer.Phone = payload.Phone;

            var updatedCustomer = await repository.UpdateCustomer(id, customer);
            return TypedResults.Ok(new CustomerResponseDTO(updatedCustomer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var result = await repository.DeleteCustomer(id);
            if (!result)
            {
                return TypedResults.NotFound("Customer not found");
            }
            return TypedResults.Ok(true);
        }

        //Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            var movies = await repository.GetAllMovies();
            if (movies == null)
            {
                return TypedResults.NotFound("No movies have been added to the database!");
            }
            else
            {
                var moviesDTO = movies.Select(m => new MovieResponseDTO(m)).ToList();
                return TypedResults.Ok(moviesDTO);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddMovie(IRepository repository, CreateMoviePayload payload)
        {
            var movie = new Movie
            {
                Title = payload.Title,
                Rating = payload.Rating,
                Description = payload.Description,
                RuntimeMins = payload.RuntimeMins
            };
            var addedMovie = await repository.AddMovie(movie);
            return TypedResults.Created($"Screening created successfully. Screening ID: {addedMovie.Id}");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, UpdateMoviePayload payload)
        {
            var movie = await repository.GetMovieById(id);
            if (movie == null)
            {
                return TypedResults.NotFound("Movie not found");
            }

            movie.Title = payload.Title;
            movie.Rating = payload.Rating;
            movie.Description = payload.Description;
            movie.RuntimeMins = payload.RuntimeMins;

            var updatedMovie = await repository.UpdateMovie(id, movie);
            return TypedResults.Ok(new MovieResponseDTO(updatedMovie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var result = await repository.DeleteMovie(id);
            if (!result)
            {
                return TypedResults.NotFound("Movie not found");
            }
            return TypedResults.Ok(true);
        }

        // Screening
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllScreenings(IRepository repository, int movieId)
        {
            var movie = await repository.GetMovieById(movieId);
            if (movie == null)
            {
                return TypedResults.NotFound("Movie not found!"); //If theres no movie
            }

            var screenings = await repository.GetAllScreenings(movieId);
            if (screenings == null || !screenings.Any())
            {
                return TypedResults.NotFound("No screenings found for this movie!"); //If theres no screenings for an added movie
            }

            var screeningsDTO = screenings.Select(s => new ScreeningResponseDTO(s)).ToList();
            return TypedResults.Ok(screeningsDTO);
        }


        // Create a screening for a movie
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository repository, int movieId, CreateScreeningPayload payload)
        {
            // Check if the movie exists
            var movie = await repository.GetMovieById(movieId);
            var existingMovie = await repository.GetMovieById(movieId);
            if (existingMovie == null)
            {
                return TypedResults.NotFound("Movie not found!");
            }

            var screening = new Screening
            {
                ScreenNumber = payload.ScreenNumber,
                Capacity = payload.Capacity,
                StartsAt = payload.StartsAt,
                MovieId = movieId
            };

            var addedScreening = await repository.AddScreening(screening);
            return TypedResults.Created($"Screening created successfully. Screening ID: {addedScreening.Id} for movie with ID: {movieId},  {movie.Title}");
        }

        //Ticket
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllTicketsForCustomer(IRepository repository, int customerId)
        {
            var tickets = await repository.GetTicketsByCustomerId(customerId);
            if (tickets == null || tickets.Count == 0)
            {
                return TypedResults.NotFound("No tickets found for this customer!");
            }
            else
            {
                var ticketDtos = tickets.Select(ticket => new TicketDto
                {
                    Id = ticket.Id,
                    NumSeats = ticket.NumSeats,
                    CreatedAt = ticket.CreatedAt,
                    UpdatedAt = ticket.UpdatedAt
                }).ToList();

                var responseData = new GetAllTicketsResponseDto
                {
                    Status = "success",
                    Data = ticketDtos
                };
                return TypedResults.Ok(responseData);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(IRepository repository, DTO.CreateTicketPayload payload)
        {
            // Check if the customer and screening exist
            var customer = await repository.GetCustomerById(payload.CustomerId);
            if (customer == null)
            {
                return TypedResults.NotFound("Customer not found");
            }

            var screening = await repository.GetScreeningById(payload.ScreeningId);
            if (screening == null)
            {
                return TypedResults.NotFound("Screening not found");
            }

            // Check if there are enough seats available - screening model ->
            if (payload.NumSeats > screening.AvailableSeats)
            {
                return TypedResults.BadRequest("Not enough seats available for booking");
            }

            // Creating the new ticket
            var ticket = new Ticket
            {
                CustomerId = payload.CustomerId,
                ScreeningId = payload.ScreeningId,
                NumSeats = payload.NumSeats
            };

            var addedTicket = await repository.AddTicket(ticket);
            return TypedResults.Created($"Ticket created successfully. Ticket ID: {addedTicket.Id}");
        }

    }
}