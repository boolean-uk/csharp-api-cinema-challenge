using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            // Create a route group for cinema-related endpoints
            var cinemaGroup = app.MapGroup("cinema");

            //customers
            cinemaGroup.MapGet("/customers", GetCustomers);
            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapPut("/customers", UpdateCustomer);
            cinemaGroup.MapDelete("/customers", DeleteCustomer);

            //movies
            cinemaGroup.MapGet("/movies", GetMovies);
            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapPut("/movies", UpdateMovie);
            cinemaGroup.MapDelete("/movies", DeleteMovie);

            //screenings
            cinemaGroup.MapGet("/screenings", GetScreening);
            cinemaGroup.MapPost("/screenings", CreateScreening);

            //tickets
            cinemaGroup.MapPost("/tickets", BookTicket);
            cinemaGroup.MapGet("/tickets/{customerid}/{screeningid}", GetTicket);


        }

        //Get Customers
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>();
            payload.data = customers;


            return TypedResults.Ok(payload);
        }

        //Create Customer
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPost customer, int id)
        {
            var createdCustomer = await repository.CreateCustomer(customer, id);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();


            if (createdCustomer == null)
            {
                return Results.BadRequest("Failed to create the patient.");
            }

            var customerDTO = new CustomerDTO()
            {
                Id = id,
                CustomerName = createdCustomer.CustomerName,
                EmailAdress = createdCustomer.EmailAdress,
                PhoneNumber = createdCustomer.PhoneNumber,
                CreatedAt = createdCustomer.CreatedAt,
                UpdatedAt = createdCustomer.UpdatedAt
            };
            payload.data = customerDTO;
            return TypedResults.Created($"{payload.data.CustomerName}", payload);
        }

        //Update Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPost customer)
        {
            var existingCustomer = await repository.UpdateCustomer(id, customer);

            if (existingCustomer == null)
            {
                return Results.NotFound("Customer not found.");
            }

            var customerDTO = new CustomerDTO()
            {
                Id = id,
                CustomerName = existingCustomer.CustomerName,
                EmailAdress = existingCustomer.EmailAdress,
                PhoneNumber = existingCustomer.PhoneNumber,
                CreatedAt = existingCustomer.CreatedAt,
                UpdatedAt = existingCustomer.UpdatedAt
            };

            return Results.Ok(customerDTO);
        }

        //Delete Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)

        {
            var deletedCustomer = await repository.DeleteCustomer(id);
            Payload<Customer> payload = new Payload<Customer>();

            if (deletedCustomer == null)
            {
                return Results.NotFound("Customer not found.");
            }
            payload.data = deletedCustomer;
            return Results.Ok(payload);
        }


        //Get Movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>();
            payload.data = movies;
            return TypedResults.Ok(payload);
        }

        //Create Movie
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePost movie, int id)
        {
            var createdMovie = await repository.CreateMovie(movie, id);
            Payload<MovieDTO> payload = new Payload<MovieDTO>();

            if (createdMovie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            var movieDTO = new MovieDTO()
            {
                Id = id,
                Title = createdMovie.Title,
                Rating = createdMovie.Rating,
                Description = createdMovie.Description,
                RuntimeMins = createdMovie.RuntimeMins,
                CreatedAt = createdMovie.CreatedAt,
                UpdatedAt = createdMovie.UpdatedAt,
                Screenings = createdMovie.Screenings.Select(x => new ScreeningDTO()
                {
                    Id = x.ScreeningId,
                    ScreenNumber = x.ScreenNumber,
                    ScreenCapacity = x.ScreenCapacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt
                })
            };
            payload.data = movieDTO;
            return TypedResults.Created($"{payload.data.Title}", payload);
        }

        //Update Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, MoviePost movie)
        {
            var existingMovie = await repository.UpdateMovie(id, movie);

            if (existingMovie == null)
            {
                return Results.NotFound("Movie not found.");
            }

            var movieDTO = new MovieDTO()
            {
                Id = id,
                Title = existingMovie.Title,
                Rating = existingMovie.Rating,
                Description = existingMovie.Description,
                RuntimeMins = existingMovie.RuntimeMins,
                CreatedAt = existingMovie.CreatedAt,
                UpdatedAt = existingMovie.UpdatedAt
            };

            return Results.Ok(movieDTO);
        }

        //Delete Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var deletedMovie = await repository.DeleteMovie(id);
            Payload<MovieDTO> payload = new Payload<MovieDTO>();


            if (deletedMovie == null)
            {
                return Results.NotFound("Movie not found.");
            }
            payload.data = deletedMovie;
            return Results.Ok(payload);
        }

        //Get Screenings
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreening(IRepository repository, int movieId)
        {
            var screenings = await repository.GetScreeningsForMovie(movieId);
            Payload<IEnumerable<ScreeningDTO>> payload = new Payload<IEnumerable<ScreeningDTO>>();
            payload.data = screenings;
            return TypedResults.Ok(payload);
        }



        //Create Screening
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPost screening, int movieId)
        {
            var createdScreening = await repository.CreateScreeningForMovie(screening, movieId);
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();

            if (createdScreening == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            var screeningDTO = new ScreeningDTO()
            {
                Id = createdScreening.ScreeningId,
                ScreenNumber = createdScreening.ScreenNumber,
                ScreenCapacity = createdScreening.ScreenCapacity,
                StartsAt = createdScreening.StartsAt,
                CreatedAt = createdScreening.CreatedAt,
                UpdatedAt = createdScreening.UpdatedAt
            };
            payload.data = screeningDTO;

            return TypedResults.Created($"{payload.data.Id}", payload);
        }

        //Create Ticket
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> BookTicket(IRepository repository, int customerId, int screeningId, TicketPost ticket)
        {
            //Validate the input from client (swagger)
            if (ticket.SeatNumber <= 0)
            {
                return Results.BadRequest(new Payload<string> { status = "Failure", data = "Invalid seatnumber" });
            }

            // Create a new ticket
            var createdTicket = await repository.BookTicket(customerId, screeningId, ticket.SeatNumber);
            // Return the created ticket
            return TypedResults.Created("", new Payload<TicketDTO> { data = new TicketDTO(createdTicket)});
        }

        //Get Tickets
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTicket(IRepository repository, int customerid, int screeningid)
        {
            var tickets = await repository.GetTickets(customerid, screeningid);
            List<TicketDTO> ticketDTOs = new List<TicketDTO>();
            foreach(var ticket in tickets)
            {
                ticketDTOs.Add(new TicketDTO(ticket));
            }
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>();
            payload.data = ticketDTOs;
            return TypedResults.Ok(payload);
        }

    }
}
