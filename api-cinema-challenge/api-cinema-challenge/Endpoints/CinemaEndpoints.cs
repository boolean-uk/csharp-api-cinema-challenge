using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {


            var movieGroup = app.MapGroup("movies");
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapGet("/{id}", GetMovie);
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            //screenings for movies
            movieGroup.MapPost("/{movieId}/screenings", CreateScreening);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);



            var customerGroup = app.MapGroup("customers");
            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapGet("/{id}", GetCustomer);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            return Results.Ok(await repository.GeneratePayload(movies));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovie(IRepository repository, int id)
        {
            var movie = await repository.GetMovie(id);
            if (movie == null)
            {
                return TypedResults.NotFound(await repository.GenerateErrorPayload(movie, $"Movie with id {id} was not found"));
            }

            var resp = await repository.GeneratePayload(movie);

            return Results.Ok(resp);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MovieDTO? movie)
        {

            var movieCreated = await repository.CreateMovie(movie);
            return Results.Created($"movies/{movieCreated.Id}", await repository.GeneratePayload(movieCreated));
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, MovieDTO? movie)
        {
            var updatedMovie = await repository.UpdateMovie(id, movie);
            return Results.Created($"movies/{updatedMovie.Id}", await repository.GeneratePayload(updatedMovie));

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var deletedMovie = await repository.DeleteMovie(id);
            if (deletedMovie == null)
            {
                return Results.NotFound(await repository.GenerateErrorPayload(deletedMovie, $"Movie with id {id} was not found"));
            }

            return Results.Ok(await repository.GeneratePayload(deletedMovie));

        }

        // Screenings for movies

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository repository, int movieId, ScreeningDTO screeningDTO)
        {
            var movie = await repository.GetMovie(movieId);
            if(movie == null)
            {
                return Results.NotFound(await repository.GenerateErrorPayload(movie, $"Movie with id {movieId} was not found"));
            }


            var screeningCreated = await repository.CreateScreening(screeningDTO, movieId);
            return Results.Created($"/movies/{movieId}/screenings", await repository.GeneratePayload(screeningCreated));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            var screenings = await repository.GetScreenings(movieId);
            return Results.Ok(await repository.GeneratePayload(screenings));

        }



        // Customers

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();
            return Results.Ok(await repository.GeneratePayload(customers));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomer(IRepository repository, int id)
        {
            var customer = await repository.GetCustomer(id);
            if (customer == null)
            {
                return TypedResults.NotFound(await repository.GenerateErrorPayload(customer, $"Customer with id {id} was not found"));
            }

            var resp = await repository.GeneratePayload(customer);

            return Results.Ok(resp);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerDTO? customerDTO)
        {

            var customerCreated = await repository.CreateCustomer(customerDTO);
            return Results.Created($"/cinema/movies/{customerCreated.Id}", await repository.GeneratePayload(customerCreated));
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerDTO? customer)
        {
            var updatedCustomer = await repository.UpdateCustomer(id, customer);
            return Results.Created($"/cinema/movies/{updatedCustomer.Id}", await repository.GeneratePayload(updatedCustomer));

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var deletedCustomer = await repository.DeleteCustomer(id);
            if (deletedCustomer == null)
            {
                return Results.BadRequest(await repository.GenerateErrorPayload(deletedCustomer, $"Customer with id {id} was not found"));
            }

            return Results.Ok(await repository.GeneratePayload(deletedCustomer));
        }



    }
}
