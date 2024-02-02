using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.DTOs;
using static api_cinema_challenge.DTOs.Payloads;
using Microsoft.Extensions.Hosting;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaApi
    {
        public static void ConfigureCinemaApiEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");
            var movieGroup = app.MapGroup("movies");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();
            var customerDto = new List<CustomerDTO>();
            foreach (Customer customer in customers)
            {
                customerDto.Add(new CustomerDTO(customer));
            }
            return TypedResults.Ok(customerDto);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, IRepository repository)
        {
            // validate: a) payload has all of the properties we need (ie. they are NOT null)
            if (payload.Name == null || payload.Name == "")
            {
                return Results.BadRequest("A non-empty Name is required");
            }

            if(repository.IsValidEmail(payload.Email) == false)
            {
                return Results.BadRequest("Not a valid Email");
            }

            Customer? customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            return TypedResults.Created($"/customers/{customer.Id}", new CustomerDTO(customer));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(int customerId, UpdateCustomerPayload payload, IRepository Repository)
        {
            Customer? customer = await Repository.GetCustomer(customerId);
            if (customer == null)
            {
                return TypedResults.NotFound();
            }
            Customer? customerUpdated = await Repository.UpdateCustomer(customerId, payload.Name, payload.Email, payload.Phone);
            if (customerUpdated == null)
            {
                return Results.BadRequest("Failed to update customer.");
            }

            return TypedResults.Created($"/customers/{customerUpdated.Id}", new CustomerDTO(customerUpdated));
        }



        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteCustomer(int customerId, IRepository repository)
        {
            Customer? customer = await repository.GetCustomer(customerId);
            if (customer == null)
            {
                return TypedResults.NotFound();
            }
            Customer? customerDelete = await repository.DeleteCustomer(customerId);
            if (customerDelete == null)
            {
                return Results.BadRequest("Failed to delete customer.");
            }

            return TypedResults.Ok(new CustomerDTO(customer));
        }








        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            var movieDto = new List<MovieDTO>();
            foreach (Movie movie in movies)
            {
                movieDto.Add(new MovieDTO(movie));
            }
            return TypedResults.Ok(movieDto);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(CreateMoviePayload payload, IRepository repository)
        {
            // validate: a) payload has all of the properties we need (ie. they are NOT null)
            if (payload.Title == null || payload.Title == "")
            {
                return Results.BadRequest("A non-empty Name is required");
            }

            Movie? movie = await repository.CreateMovie(payload.Title, payload.Rating, payload.Description, payload.RuntimeMins);
            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            return TypedResults.Created($"/movies/{movie.Id}", new MovieDTO(movie));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(int movieId, UpdateMoviePayload payload, IRepository Repository)
        {
            Movie? movie = await Repository.GetMovie(movieId);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }
            Movie? movieUpdated = await Repository.UpdateMovie(movieId, payload.Title, payload.Rating, payload.Description, payload.RuntimeMins);
            if (movieUpdated == null)
            {
                return Results.BadRequest("Failed to update movie.");
            }

            return TypedResults.Created($"/movies/{movieUpdated.Id}", new MovieDTO(movieUpdated));
        }



        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteMovie(int movieId, IRepository repository)
        {
            Movie? movie = await repository.GetMovie(movieId);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }
            Movie? movieDelete = await repository.DeleteMovie(movieId);
            if (movieDelete == null)
            {
                return Results.BadRequest("Failed to delete movie.");
            }

            return TypedResults.Ok(new MovieDTO(movie));
        }





        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetScreenings(int movieId, IRepository repository)
        {
            Movie? movie = await repository.GetMovie(movieId);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }
            var screenings = await repository.GetScreenings(movieId);
            var screeningDto = new List<ScreeningDTO>();
            foreach (Screenings screening in screenings)
            {
                screeningDto.Add(new ScreeningDTO(screening));
            }
            return TypedResults.Ok(screeningDto);
        }


        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(int movieId, [FromBody] CreateScreeningPayload payload, IRepository repository)
        {
            // validate: a) payload has all of the properties we need (ie. they are NOT null)
            if (payload.ScreenNumber == null || payload.Capacity == null)
            {
                return Results.BadRequest("A ScreenNumber/capacity/Start time is required");
            }
            
            Screenings? screening = await repository.CreateScreening(movieId, payload.ScreenNumber, payload.Capacity, payload.StartsAt);
            if (screening == null)
            {
                return Results.BadRequest("Failed to create screening.");
            }

            return TypedResults.Created($"/movies/{movieId}/", new ScreeningDTO(screening));
        }
    }
}




        