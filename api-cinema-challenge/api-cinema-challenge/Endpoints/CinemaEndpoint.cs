using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/customers", GetAllCustomers);
            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);

            cinemaGroup.MapGet("/movies", GetAllMovies);
            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);

            cinemaGroup.MapGet("/screenings", GetAllScreenings);
            cinemaGroup.MapPost("/screenings", CreateScreening);
        }

        //---------------------------- Customer -------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.GetAll(); 
            return TypedResults.Ok(customers);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerDTO customerDTO)
        {
            var customer = new Customer
            {
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await repository.Add(customer);
            return TypedResults.Created($"Customer {customer.Name} with id {customer.Id} has been added.");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerDTO customerDTO)
        {
            var customer = await repository.Get(id);
            if (customer == null)
                return TypedResults.NotFound($"Customer with id {id} doesn't exist");

            customer.Name = customerDTO.Name;
            customer.Email = customerDTO.Email;
            customer.Phone = customerDTO.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            await repository.Update(customer);
            return TypedResults.Ok(customer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.Get(id);
            if (customer == null)
                return TypedResults.NotFound($"Customer with id {id} doesn't exist");

            await repository.Delete(id); 
            return TypedResults.Ok(customer);
        }

        //------------------------------ Movie ------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.GetAll();
            return TypedResults.Ok(movies);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MovieDTO movieDTO)
        {
            var movie = new Movie
            {
                Title = movieDTO.Title,
                Rating = movieDTO.Rating,
                Description = movieDTO.Description,
                RuntimeMins = movieDTO.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await repository.Add(movie);
            return TypedResults.Created($"Movie {movie.Title} with id {movie.Id} has been added.");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieDTO movieDTO)
        {
            var movie = await repository.Get(id);
            if (movie == null)
                return TypedResults.NotFound($"Movie with id {id} doesn't exist");

            movie.Title = movieDTO.Title;
            movie.Rating = movieDTO.Rating;
            movie.Description = movieDTO.Description;
            movie.RuntimeMins = movieDTO.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            await repository.Update(movie);
            return TypedResults.Ok(movie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var movie = await repository.Get(id);
            if (movie == null)
                return TypedResults.NotFound($"Movie with id {id} doesn't exist");

            await repository.Delete(id);
            return TypedResults.Ok(movie);
        }

        //----------------------- Screening ----------------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreenings(IRepository<Screening> repository)
        {
            var screenings = await repository.GetAll();
            return TypedResults.Ok(screenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, ScreeningDTO screeningDTO)
        {
            var screening = new Screening
            {
                ScreenNumber = screeningDTO.ScreenNumber,
                Capacity = screeningDTO.Capacity,
                StartsAt = screeningDTO.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await repository.Add(screening);
            return TypedResults.Created($"Screening with id {screening.Id} has been added.");
        }
    }
}
