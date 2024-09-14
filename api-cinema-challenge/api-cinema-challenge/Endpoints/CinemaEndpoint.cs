using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.ViewModel;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            // Customers
            cinema.MapPost("/customers/create", CreateCustomer);
            cinema.MapGet("/customers", GetCustomers);
            cinema.MapPut("/customers/update/{id}", UpdateCustomerById);
            cinema.MapDelete("/customers/delete/{id}", DeleteCustomerById);

            // Movies
            cinema.MapPost("/movies/create", CreateMovie);
            cinema.MapGet("/movies", GetAllMovies);
            cinema.MapPut("/movies/update/{id}", UpdateMovieById);
            cinema.MapDelete("/movies/delete/{id}", DeleteMovieById);

            // Screenings
            cinema.MapPost("/screenings/create", CreateScreening);
            cinema.MapGet("/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel model)
        {
            try
            {
                Payload<Customer> payload = new Payload<Customer>();

                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            try 
            {
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomerById(IRepository repository, int id)
        {
            try
            {
                Payload<Customer> payload = new Payload<Customer>();

                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomerById(IRepository repository, int id)
        {
            try
            {
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel model)
        {
            try
            {
                Payload<Movie> payload = new Payload<Movie>();

                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            try
            {
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovieById(IRepository repository, int id)
        {
            try
            {
                Payload<Movie> payload = new Payload<Movie>();

                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovieById(IRepository repository, int id)
        {
            try
            {
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPostModel model, int movieId)
        {
            try
            {
                Payload<Screening> payload = new Payload<Screening>();

                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            try
            {
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
