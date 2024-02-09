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






        }

        //Get Customers
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();

            return TypedResults.Ok(customers);
        }

        //Create Customer
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPost customer, int id)
        {
            var createdCustomer = await repository.CreateCustomer(customer, id);

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

            return TypedResults.Created($"{customerDTO.CustomerName}", customerDTO);
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

            if (deletedCustomer == null)
            {
                return Results.NotFound("Customer not found.");
            }

            return Results.Ok(deletedCustomer);
        }


        //Get Movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();

            return TypedResults.Ok(movies);
        }

        //Create Movie
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePost movie, int id)
        {
            var createdMovie= await repository.CreateMovie(movie, id);

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
                UpdatedAt = createdMovie.UpdatedAt
            };

            return TypedResults.Created($"{movieDTO.Title}", movieDTO);
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
            var deletedCustomer = await repository.DeleteMovie(id);

            if (deletedCustomer == null)
            {
                return Results.NotFound("Movie not found.");
            }

            return Results.Ok(deletedCustomer);
        }

        //Get Screenings
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreening(IRepository repository, int movieId)
        {
            var screenings = await repository.GetScreeningsForMovie(movieId);

            return TypedResults.Ok(screenings);
        }



        //Create Screening
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPost screening, int movieId)
        {
            var createdScreening = await repository.CreateScreeningForMovie(screening, movieId);

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

            return TypedResults.Created($"{screeningDTO.Id}", screeningDTO);
        }
    }
}
