
using api_cinema_challenge.DTOS;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var CinemaGroup = app.MapGroup("Cinema");

            CinemaGroup.MapGet("/Customers", GetCustomers);
            CinemaGroup.MapPost("/Customers", CreateCustomer);
            CinemaGroup.MapPut("/Customers", UpdateCustomer);
            CinemaGroup.MapDelete("/Customers", DeleteCustomer);

            CinemaGroup.MapGet("/Movies", GetMovies);
            CinemaGroup.MapPost("/Movies", CreateMovie);
            CinemaGroup.MapPut("/Movies", UpdateMovie);
            CinemaGroup.MapDelete("/Movies", DeleteMovie);

            CinemaGroup.MapGet("/Screenings", GetScreenings);
            CinemaGroup.MapPost("/Screenings", CreateScreening);
        }


        private static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();

            return TypedResults.Ok(customers);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateCustomer(IRepository repository, CreateCustomerDTO createCustomerDTO)
        {
            var createdCustomer = await repository.CreateCustomer(createCustomerDTO);
            if (createdCustomer != null)
            {
                return TypedResults.Ok(createdCustomer);
            }
            else
            {
                return Results.BadRequest("Failed to create the Customer.");
            }
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateCustomer(IRepository repository, CreateCustomerDTO updateCustomerDTO,  int id)
        {
            {
                var updatedCustomer = await repository.UpdateCustomer(updateCustomerDTO, id);

                if (updatedCustomer == null)
                {
                    return Results.NotFound($"Customer with id = {id} not found.");
                }

                return TypedResults.Ok(updatedCustomer);
            }
        }
        private static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var deletedCustomer = await repository.DeleteCustomer(id);

            if (deletedCustomer == null)
            {
                return Results.NotFound($"Customer with id = {id} not found.");
            }

            return TypedResults.Ok(deletedCustomer);
        }

        private static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();

            return TypedResults.Ok(movies);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovie(IRepository repository, CreateMovieDTO createMovieDTO)
        {
            var createdMovie = await repository.CreateMovie(createMovieDTO);
            if (createdMovie != null)
            {
                return TypedResults.Ok(createdMovie);
            }
            else
            {
                return Results.BadRequest("Failed to create the Movie.");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateMovie(IRepository repository, CreateMovieDTO updateMovieDTO, int id)
        {
            var updatedMovie = await repository.UpdateMovie(updateMovieDTO, id);

            if (updatedMovie == null)
            {
                return Results.NotFound($"Movie with id = {id} not found.");
            }

            return TypedResults.Ok(updatedMovie);
        }

        private static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var deletedMovie = await repository.DeleteMovie(id);

            if (deletedMovie == null)
            {
                return Results.NotFound($"Movie with id = {id} not found.");
            }

            return TypedResults.Ok(deletedMovie);
        }

        private static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            var screeningDTO = await repository.GetScreeningsById(id);

            if (screeningDTO == null)
            {
                return Results.NotFound($"Screenings with Movie id = {id} not found.");
            }

            return TypedResults.Ok(screeningDTO);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateScreening(IRepository repository, CreateScreeningDTO createScreeningDTO)
        {
            var createdScreening = await repository.CreateScreening(createScreeningDTO);
            if (createdScreening != null)
            {
                return TypedResults.Ok(createdScreening);
            }
            else
            {
                return Results.BadRequest("Failed to create the Screening.");
            }
        }


    }
}
