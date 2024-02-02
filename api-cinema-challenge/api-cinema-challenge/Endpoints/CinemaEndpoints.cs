using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO.Pipes;
using System.Globalization;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {

        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapGet("/customers", GetCustomers);
            // cinemaGroup.MapGet("/customers/{id}", GetCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);

            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapGet("/movies", GetMovies);
            // cinemaGroup.MapGet("/movies/{id}", GetMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);

            cinemaGroup.MapPost("/movies/{id}/screenings", CreateScreening);
            cinemaGroup.MapGet("/movies/{id}/screenings", GetScreenings);
            
        }

        /// AID FUNCTIONS
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool correctDateTimeFormat(string inputString)
        {
            // Console.WriteLine($"datetime format: {inputString}");  // 2024-02-02 07:06:40

            return DateTime.TryParseExact(inputString, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);
   
        }

        /// CUSTOMERS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        { 

            var customers = await repository.GetCustomers();

            var customerDTO = new List<CustomerDTO>();

            foreach (Customer customer in customers)
            {
                customerDTO.Add(new CustomerDTO(customer));
            }

            return TypedResults.Ok(customerDTO);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, IRepository repository)
        {
         
            if (payload.Name == null || payload.Phone == "" || payload.Email == "")
            {
                return Results.BadRequest("Non-empty fields are required.");
            }

            if (IsValidEmail(payload.Email) == false)
            {
                return Results.BadRequest("Email needs to be in correct format.");
            }
        
            Customer? customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            return TypedResults.Created($"/customers{customer.Id}", new CustomerDTO(customer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteCustomer(int id, IRepository repository)
        {

            Customer? customer = await repository.DeleteCustomer(id, PreloadPolicy.PreloadRelations);

            if (customer == null)
            {
                return Results.NotFound("customer not found");
            }

            var customerDTO = new CustomerDTO(customer);

            repository.SaveChanges();

            return TypedResults.Ok(customerDTO);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(int id, UpdateCustomerPayload payload, IRepository repository)
        {
         
            if (payload.name == "" && payload.phone == "" && payload.email == "")
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (IsValidEmail(payload.email) == false)
            {
                return Results.BadRequest("Email needs to be in correct format.");
            }

            Customer? customer = await repository.UpdateCustomer(id, payload.name, payload.email, payload.phone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            return TypedResults.Created($"/customers{customer.Id}", new CustomerDTO(customer));
        }




        /// MOVIES
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        { 

            var movies = await repository.GetMovies();

            var movieDTO = new List<MovieDTO>();

            foreach (Movie movie in movies)
            {
                movieDTO.Add(new MovieDTO(movie));
            }

            return TypedResults.Ok(movieDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(CreateMoviePayload payload, IRepository repository)
        {
         
            if (payload.title == "" || payload.rating == "" || payload.description == "" || payload.runtimeMins < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.title == null || payload.rating == null || payload.description == null )
            {
                return Results.BadRequest("Non-null fields are required");
            }
        
            Movie? movie = await repository.CreateMovie(payload.title, payload.rating, payload.description, payload.runtimeMins);

            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            repository.SaveChanges();

            return TypedResults.Created($"/movies{movie.Id}", new MovieDTO(movie));
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteMovie(int id, IRepository repository)
        {

            Movie? movie = await repository.DeleteMovie(id, PreloadPolicy.PreloadRelations);

            if (movie == null)
            {
                return Results.NotFound("Movie not found");
            }

            var MovieDTO = new MovieDTO(movie);

            repository.SaveChanges();

            return TypedResults.Ok(MovieDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(int id, UpdateMoviePayload payload, IRepository repository)
        {
         
            if (payload.title == "" || payload.rating == "" || payload.description == "" || payload.runtimeMins < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.title == null || payload.rating == null || payload.description == null )
            {
                return Results.BadRequest("Non-null fields are required");
            }
        
            Movie? movie = await repository.UpdateMovie(id, payload.title, payload.rating, payload.description, payload.runtimeMins);

            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            repository.SaveChanges();

            return TypedResults.Created($"/movies{movie.Id}", new MovieDTO(movie));
        }






        /// SCREENINGS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(int id, IRepository repository)
        { 

            var screenings = await repository.GetScreenings(id);

            var screeningDTO = new List<ScreeningDTO>();

            foreach (Screening screening in screenings)
            {
                screeningDTO.Add(new ScreeningDTO(screening));
            }

            return TypedResults.Ok(screeningDTO);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  // [AsParameters]
        public static async Task<IResult> CreateScreening(int id, CreateScreeningPayload payload, IRepository repository)
        {

            if (payload.screenNumber <= 0 || payload.capacity <= 0 || id < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (correctDateTimeFormat(payload.startsAt) == false) 
            {
                return Results.BadRequest("Give datetime in the correct format: YYYY-MM-DD HH:MM:SS");
            }
        
            Screening? screening = await repository.CreateScreening(
                payload.screenNumber,
                payload.capacity,
                DateTime.Parse(payload.startsAt).ToUniversalTime(),
                id);


            repository.SaveChanges();

            return TypedResults.Created($"/screenings{screening.Id}", new ScreeningDTO(screening));
        }
    }
}
