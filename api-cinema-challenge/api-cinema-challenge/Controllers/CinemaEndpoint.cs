using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace api_cinema_challenge.Controllers

{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoints(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("/");

            cinemaGroup.MapPost("customers", CreateCustomer);
            cinemaGroup.MapGet("customers", GetCustomers);
            cinemaGroup.MapPut("customers{c_id}", UpdateCustomer);
            cinemaGroup.MapDelete("customers{c_id}", DeleteCustomer);

            cinemaGroup.MapPost("movies", CreateMovie);
            cinemaGroup.MapGet("movies", GetMovies);
            cinemaGroup.MapPut("movies{m_id}", UpdateMovie);
            cinemaGroup.MapDelete("movies{m_id}", DeleteMovie);

            cinemaGroup.MapPost("movies/{m_id}/screenings", CreateScreening);
            cinemaGroup.MapGet("movies/{m_id}/screenings", GetScreenings);

            cinemaGroup.MapPost("customers/{c_id}/screenings/{s_id}", CreateTicket);
            cinemaGroup.MapGet("customers/{c_id}/screenings{s_id}", GetTickets);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPost customer)
        {
            if (customer == null)
            {
                return TypedResults.BadRequest();
            }
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            var newCustomer = await repository.CreateCustomer(customer);
            var customerDTO = new CustomerDTO()
            {
                Id = newCustomer.Id,
                Name = newCustomer.Name,
                Email = newCustomer.Email,
                Phone = newCustomer.Phone,
                CreatedAt = newCustomer.CreatedAt,
                UpdatedAt = newCustomer.UpdatedAt
            };
            payload.data = customerDTO;
            return TypedResults.Created($"{payload.data.Name}", payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>();
            var customer = await repository.GetCustomers();
            payload.data = customer;
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, CustomerPut customer, int id)
        {
            var updated = await repository.UpdateCustomer(customer, id);
            var customerDTO = new CustomerDTO()
            {
                Id = updated.Id,
                Name = updated.Name,
                Email = updated.Email,
                Phone = updated.Phone,
                CreatedAt = updated.CreatedAt,
                UpdatedAt = updated.UpdatedAt
                
            };
            return TypedResults.Created($"{customerDTO.Name}", customerDTO);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            Payload<Customer> payload = new Payload<Customer>();
            var customer = await repository.DeleteCustomer(id);
            payload.data = customer;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePost movie)
        {
            if (movie == null)
            {
                return TypedResults.BadRequest();
            }
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            var newMovie = await repository.CreateMovie(movie);
            var movieDTO = new MovieDTO()
            {
                Id = newMovie.Id,
                Title = newMovie.Title,
                Rating = newMovie.Rating,
                Description = newMovie.Description,
                RuntimeMins = newMovie.RuntimeMins,
                CreatedAt = newMovie.CreatedAt,
                UpdatedAt = newMovie.UpdatedAt,
                Screenings = newMovie.Screenings.Select(x => new ScreeningDTO()
                {
                    Id = x.Id,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt
                })
            };
            payload.data = movieDTO;
            return TypedResults.Created($"{payload.data.Title}", payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>();
            payload.data = movies;
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(IRepository repository, MoviePut movie, int id)
        {
            var updated = await repository.UpdateMovie(movie, id);

            if (updated == null)
            {
                return TypedResults.BadRequest();
            }
            var movieDTO = new MovieDTO()
            {
                Id =updated.Id,
                Title = updated.Title,
                Rating = updated.Rating,
                Description = updated.Description,
                RuntimeMins = updated.RuntimeMins,
                CreatedAt = updated.CreatedAt,
                UpdatedAt = updated.UpdatedAt
            };
            return TypedResults.Created($"{movieDTO.Title}", movieDTO);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var movie = await repository.DeleteMovie(id);
            Payload<Movie> payload = new Payload<Movie>();
            payload.data = movie;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPost screening, int movieId)
        {
            if (screening == null)
            {
                return TypedResults.BadRequest();
            }
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
            var newScreening = await repository.CreateScreening(screening, movieId);
            var screeningDTO = new ScreeningDTO()
            {
                Id = newScreening.Id,
                ScreenNumber = newScreening.ScreenNumber,
                Capacity = newScreening.Capacity,
                StartsAt = newScreening.StartsAt,
                CreatedAt = newScreening.CreatedAt,
                UpdatedAt = newScreening.UpdatedAt
            };
            payload.data = screeningDTO;
            return TypedResults.Created($"{payload.data.ScreenNumber}", payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            Payload<IEnumerable<ScreeningDTO>> payload = new Payload<IEnumerable<ScreeningDTO>>();
            var screening = await repository.GetScreenings(id);
            payload.data = screening;
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> CreateTicket(IRepository repository, int customerId, int screeningId, TicketPost ticket)
        {
            if (customerId == null)
            {
                return TypedResults.BadRequest();
            }
            Payload<TicketDTO> payload = new Payload<TicketDTO>();
            var newTicket = await repository.CreateTicket(customerId, screeningId, ticket);
            var ticketDTO = new TicketDTO()
            {
                Id = newTicket.Id,
                NumSeats = newTicket.NumSeats,
                CustomerId = newTicket.CustomerId,
                ScreeningId = newTicket.ScreeningId
            };
            payload.data = ticketDTO;
            return TypedResults.Created($"{ticketDTO.Id}", ticketDTO);
        }

        public static async Task<IResult> GetTickets(IRepository repository, int customerId, int screeningId)
        {
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>();
            var tickets = await repository.GetTickets(customerId, screeningId);
            payload.data = tickets;
            return TypedResults.Ok(payload);
        }
    }
} 
