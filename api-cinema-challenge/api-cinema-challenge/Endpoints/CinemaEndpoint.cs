using System.Net.Http.Headers;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");
            cinema.MapGet("customers", GetAllCustomers);
            cinema.MapPost("customers", CreateCustomer);
            cinema.MapPut("customers/{id}", UpdateCustomer);
            cinema.MapDelete("customers/{id}", DeleteCustomer);
            cinema.MapGet("movies", GetAllMovies);
            cinema.MapPost("movies", CreateMovie);
            cinema.MapPut("movies/{id}", UpdateMovie);
            cinema.MapDelete("movies/{id}", DeleteMovie);
            cinema.MapGet("movies/{id}/screenings", GetAllScreeningsByMovieID);
            cinema.MapPost("movies/{id}/screenings", CreateScreening);
            cinema.MapPost("customers/{customers_id}/screenings/{screening_id}", CreateTicket);
            cinema.MapGet("customers/{customers_id}/screenings/{screening_id}", GetAllTicketsByCustomerAndScreeningID);
        }

        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            var customers = await repository.GetAllCustomers();
            return TypedResults.Ok(new CustomerResponseDTO("success", customers));
        }

        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, IRepository repository)
        {
            if (string.IsNullOrEmpty(payload.Name))
            {
                return TypedResults.BadRequest("Name is required");
            }
            if (string.IsNullOrEmpty(payload.Email))
            {
                return TypedResults.BadRequest("Email is required");
            }
            if (string.IsNullOrEmpty(payload.Phone))
            {
                return TypedResults.BadRequest("Phone is required");
            }
            var customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone, payload);
            return TypedResults.Ok(new CustomerResponseDTO("success", new List<Customer>(){customer}));
        }

        public static async Task<IResult> UpdateCustomer(int id, UpdateCustomerPayload payload, IRepository repository)
        {
            if (string.IsNullOrEmpty(payload.Name))
            {
                return TypedResults.BadRequest("Name is required");
            }
            if (string.IsNullOrEmpty(payload.Email))
            {
                return TypedResults.BadRequest("Email is required");
            }
            if (string.IsNullOrEmpty(payload.Phone))
            {
                return TypedResults.BadRequest("Phone is required");
            }
            var customer = await repository.UpdateCustomer(id, payload.Name, payload.Email, payload.Phone, payload);
            if (customer == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new CustomerResponseDTO("success", new List<Customer>(){customer}));
        }

        public static async Task<IResult> DeleteCustomer(int id, IRepository repository)
        {
            var deleted = await repository.DeleteCustomer(id);
            if (!deleted)
            {
                return TypedResults.NotFound();
            }
            var customers = await repository.GetAllCustomers();
            return TypedResults.Ok(new CustomerResponseDTO("success", customers));
        }

        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            var movies = await repository.GetAllMovies();
            return TypedResults.Ok(new MovieListResponseDTO("success", movies));
        }

        public static async Task<IResult> CreateMovie(CreateMoviePayload payload, IRepository repository)
        {
            if (string.IsNullOrEmpty(payload.Title))
            {
                return TypedResults.BadRequest("Title is required");
            }
            if (string.IsNullOrEmpty(payload.Rating))
            {
                return TypedResults.BadRequest("Rating is required");
            }
            if (string.IsNullOrEmpty(payload.Description))
            {
                return TypedResults.BadRequest("Description is required");
            }
            if (payload.RunTimeMinutes <= 0)
            {
                return TypedResults.BadRequest("RunTimeMinutes must be greater than 0");
            }
            var movie = await repository.CreateMovie(payload.Title, payload.Rating, payload.Description, payload.RunTimeMinutes, payload);
            return TypedResults.Ok(new MovieListResponseDTO("success", new List<Movie>(){movie}));
        }

        public static async Task<IResult> UpdateMovie(int id, UpdateMoviePayload payload, IRepository repository)
        {
            if (string.IsNullOrEmpty(payload.Title))
            {
                return TypedResults.BadRequest("Title is required");
            }
            if (string.IsNullOrEmpty(payload.Rating))
            {
                return TypedResults.BadRequest("Rating is required");
            }
            if (string.IsNullOrEmpty(payload.Description))
            {
                return TypedResults.BadRequest("Description is required");
            }
            if (payload.RunTimeMinutes <= 0)
            {
                return TypedResults.BadRequest("RunTimeMinutes must be greater than 0");
            }
            var movie = await repository.UpdateMovie(id, payload.Title, payload.Rating, payload.Description, payload.RunTimeMinutes, payload);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new MovieListResponseDTO("success", new List<Movie>(){movie}));
        }

        public static async Task<IResult> DeleteMovie(int id, IRepository repository)
        {
            var deleted = await repository.DeleteMovie(id);
            if (!deleted)
            {
                return TypedResults.NotFound();
            }
            var movies = await repository.GetAllMovies();
            return TypedResults.Ok(new MovieListResponseDTO("success", movies));;
        }

        public static async Task<IResult> GetAllScreeningsByMovieID(int id, IRepository repository)
        {
            var screenings = await repository.GetAllScreeningsByMovieID(id);
            if (screenings.Count == 0)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new ScreeningListResponseDTO("success", screenings));
        }

        public static async Task<IResult> CreateScreening(CreateScreeningPayload payload, IRepository repository)
        {
            if (payload.MovieId <= 0)
            {
                return TypedResults.BadRequest("MovieId must be greater than 0");
            }
            if (payload.ScreenNumber <= 0)
            {
                return TypedResults.BadRequest("ScreenNumber must be greater than 0");
            }
            if (payload.Capacity <= 0)
            {
                return TypedResults.BadRequest("Capacity must be greater than 0");
            }
            if (payload.StartTime == default)
            {
                return TypedResults.BadRequest("StartTime is required");
            }
            Screening? screening = await repository.CreateScreening(payload.MovieId, payload.ScreenNumber, payload.Capacity, payload.StartTime, payload);

            return TypedResults.Ok(new ScreeningResponseDTO("success", screening));
        }

        public static async Task<IResult> CreateTicket(int customerId, int screeningId, CreateTicketPayload payload, IRepository repository)
        {
            if (payload.SeatNumber <= 0)
            {
                return TypedResults.BadRequest("SeatNumber must be greater than 0");
            }
            if (payload.CustomerId <= 0)
            {
                return TypedResults.BadRequest("CustomerId must be greater than 0");
            }
            if (payload.ScreeningId <= 0)
            {
                return TypedResults.BadRequest("ScreeningId must be greater than 0");
            }
            Ticket? ticket = await repository.CreateTicket(payload.SeatNumber, payload.CustomerId, payload.ScreeningId, payload);
            return TypedResults.Ok(new TicketResponseDTO("success", ticket));
        }

        public static async Task<IResult> GetAllTicketsByCustomerAndScreeningID(int customerId, int screeningId, IRepository repository)
        {
            var tickets = await repository.GetAllTicketsByCustomerAndScreeningID(customerId, screeningId);
            if (tickets.Count == 0)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new TicketListResponseDTO("success", tickets));
        }

    }
}