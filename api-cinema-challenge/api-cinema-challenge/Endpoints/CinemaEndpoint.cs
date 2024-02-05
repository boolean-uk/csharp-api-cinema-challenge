using System.Runtime.CompilerServices;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using static api_cinema_challenge.DTO.Payload;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", CreateCustomer);
            app.MapPut("/customer/{customer_id}", UpdateCustomer);
            app.MapDelete("/customer/{customer_id}", DeleteCustomer);
        }
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            app.MapGet("/movies",GetMovies);
            app.MapPost("/movies", CreateMovie);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }
        public static void ConfigureScreeningEndpoint(this WebApplication app) 
        {
            app.MapGet("/movies/{movie_id}/screenings",GetScreeningsForMovie);
            app.MapPost("/movies/{movie_id}/screenings", CreateScreening);
        }
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            app.MapPost("/customers/{customer_id}/screenings/{screening_id}", BookATicket);
            app.MapGet("/customer/{customer_id}/screenings/{screening_id}", GetCustomerTicketsForScreening);
        }
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();
            var customersDTO = new List<CustomerDTO>();
            foreach(var customer in customers)
            {
                customersDTO.Add(new CustomerDTO(customer));
            }
            return TypedResults.Ok(new CustomersOutput(customersDTO));
        }
        public static async Task<IResult> CreateCustomer(IRepository repository, CreateCustomerPayload payload) 
        {
            if (!payload.email.Contains('@')) { return TypedResults.BadRequest("Not a valid email."); }
            Customer customer = new Customer { Name = payload.name, Email = payload.email, Phone = "+"+payload.phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            var result = await repository.CreateCustomer(customer);
            if(result == null)
            {
                return TypedResults.BadRequest();
            }
            return TypedResults.Ok(new CustomerOutput(new CustomerDTO(result)));
        }
        public static async Task<IResult> UpdateCustomer(IRepository repository, UpdateCustomerPayload payload, int customerId)
        {
            Customer? customerToUpdate = await repository.GetCustomer(customerId);
            if(customerToUpdate == null) { return TypedResults.BadRequest(); }
            Customer newInfo = new Customer { Name = payload.name, Phone = payload.phone, Email = payload.email };
            var result = await repository.UpdateCustomer(customerId, newInfo);
            if(result == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new CustomerOutput(new CustomerDTO(result)));
        }
        public static async Task<IResult> DeleteCustomer(IRepository repository, int customerId)
        {
            Customer? customer = await repository.GetCustomer(customerId);
            if(customer == null) { return TypedResults.BadRequest(); }
            var result = await repository.DeleteCustomer(customerId);
            if(result == null) { return TypedResults.NotFound(); }
            return TypedResults.Ok(new CustomerOutput(new CustomerDTO(result)));
        }
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            var moviesDTO = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                moviesDTO.Add(new MovieDTO(movie));
            }
            return TypedResults.Ok(new MoviesOutput(moviesDTO));
        }
        public static async Task<IResult> CreateMovie(IRepository repository, CreateMoviePayload payload)
        {
            Movie movie = new Movie { Title = payload.title, Rating = payload.rating, Description = payload.description, RunTimeMins = payload.runtime, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            var result = await repository.CreateMovie(movie);
            if (result == null) { return TypedResults.BadRequest(); }
            foreach (CreateScreeningPayload startscreen in payload.startScreens)
            {
                Screening screening = new Screening { ScreenNumber = startscreen.screennumber, Capacity = startscreen.capacity, StartsAt = startscreen.startsAt, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
                await repository.CreateScreening(movie, screening);
            }
            return TypedResults.Ok(new MovieOutput(new MovieDTO(result)));
        }
        public static async Task<IResult> UpdateMovie(IRepository repository, UpdateMoviePayload payload, int movieId)
        {
            Movie? movieToUpdate = await repository.GetMovie(movieId);
            if (movieToUpdate == null) { return TypedResults.BadRequest(); }
            Movie newInfo = new Movie { Title = payload.title, Rating = payload.rating, Description = payload.description, RunTimeMins = payload.runtime };
            var result = await repository.UpdateMovie(movieId, newInfo);
            if (result == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new MovieOutput(new MovieDTO(result)));
        }
        public static async Task<IResult> DeleteMovie(IRepository repository, int movieId)
        {
            Movie? movie = await repository.GetMovie(movieId);
            if (movie == null) { return TypedResults.BadRequest(); }
            var result = await repository.DeleteMovie(movieId);
            if (result == null) { return TypedResults.NotFound(); }
            return TypedResults.Ok(new MovieOutput(new MovieDTO(result)));
        }
        public static async Task<IResult> CreateScreening(IRepository repository, CreateScreeningPayload payload, int movieId)
        {
            Screening screening = new Screening { ScreenNumber = payload.screennumber, Capacity = payload.capacity, StartsAt = payload.startsAt, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            Movie? movie = await repository.GetMovie(movieId);
            if(movie == null) { return TypedResults.NotFound("Could not find movie."); }
            var result = await repository.CreateScreening(movie, screening);
            if (result == null) { return TypedResults.BadRequest(); }
            return TypedResults.Ok(new ScreeningOutput(new ScreeningDTO(result)));
        }
        public static async Task<IResult> GetScreeningsForMovie(IRepository repository, int movieId)
        {
            Movie? movie = await repository.GetMovie(movieId);
            if(movie == null) { return TypedResults.BadRequest("No movie"); }
            var screenings = await repository.GetScreeningsForMovie(movieId);
            if (screenings == null) { return TypedResults.NotFound(); }
            if(screenings.Count() == 0) { return TypedResults.Ok($"No screenings scheduled for {movie.Title}."); }
            var screeningsDTO = new List<ScreeningDTO>();
            foreach (var screening in screenings)
            {
                screeningsDTO.Add(new ScreeningDTO(screening));
            }
            return TypedResults.Ok(new ScreeningsOutput(screeningsDTO));
        }
        public static async Task<IResult> BookATicket(IRepository repository, BookATicketPayload payload, int customerId, int screeningId)
        {
            Screening? screening = await repository.GetScreening(screeningId);
            Customer? customer = await repository.GetCustomer(customerId);

            if (screening == null) { return TypedResults.NotFound("Could not find screening."); }
            if(customer == null) { return TypedResults.NotFound("Could not find customer."); }
            Ticket ticket = new Ticket() { NumSeats = payload.numberofSeats, customerId = customer.Id, Customer = customer, screeningId = screening.Id, Screening = screening, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow};
            var result = await repository.BookATicket(ticket, customer, screening);
            if (result == null) { return TypedResults.BadRequest("Not enough seats available."); }
            return TypedResults.Ok(new TicketOutput(new TicketDTO(result)));
        }
        public static async Task<IResult> GetCustomerTicketsForScreening(IRepository repository, int customerId, int screeningId)
        {
            var tickets = await repository.GetCustomerTicketsForScreening(customerId, screeningId);
            if(tickets == null) { return TypedResults.BadRequest(); }
            var ticketsDTO = new List<TicketDTO>();
            foreach(Ticket ticket in tickets)
            {
                ticketsDTO.Add(new TicketDTO(ticket));
            }
            return TypedResults.Ok(new TicketsOutput(ticketsDTO));
        }
    }
}
