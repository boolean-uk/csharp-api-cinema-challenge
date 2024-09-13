using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_cinema_challenge.Controllers
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndPoints(this WebApplication app)
        {
            var Movie = app.MapGroup("movie");
            var Ticket = app.MapGroup("ticket");
            var Customer = app.MapGroup("customer");
            var Screen = app.MapGroup("screen");
            var Screening = app.MapGroup("screening");
            Customer.MapGet("/customers", GetAllCustomers);
            Customer.MapPost("/customers", CreateCustomer);
            Customer.MapPut("/customers/{id}", UpdateCustomer);
            Customer.MapDelete("/customers/{id}", DeleteCustomer);
            Movie.MapPost("/movies", CreateMovie);
            Movie.MapGet("/movies", GetAllMovies);
            Movie.MapPut("/movies/{id}", UpdateMovie);
            Movie.MapDelete("/movies/{id}", DeleteMovie);
            Screening.MapPost("/movies/{MovieID}/screenings", CreateScreening);
            Screening.MapGet("/allscreenings/{Id}", GetAllScreenings);
        } 

        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            List<Customer> customers = await repository.GetAllCustomers();

            return TypedResults.Ok(customers);
        }

        public static async Task<IResult> CreateCustomer(IRepository repository, Customer customer)
        {
            Customer addedCustomer = await repository.AddCustomer(customer);
            return TypedResults.Created("", addedCustomer);
        }

        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, Customer customer)
        {
            Customer updatedCustomer = await repository.UpdateCustomer(id, customer);
            return TypedResults.Created("", updatedCustomer);
        }

        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            Customer deletedCustomer = await repository.DeleteCustomer(id);
            return TypedResults.Ok(deletedCustomer);
        }

        public static async Task<IResult> CreateMovie(IRepository repository, Movie movie)
        {
            movie = await repository.AddMovie(movie);
            return TypedResults.Created("", movie);
        }

        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            List<Movie> movies = await repository.GetAllMovies();
            return TypedResults.Ok(movies);
        }

        public static async Task<IResult> UpdateMovie(IRepository repository, int id, Movie movie)
        {
            movie = await repository.UpdateMovie(id, movie);
            return TypedResults.Created("", movie);
        }

        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            Movie movie = await repository.DeleteMovie(id);
            return TypedResults.Ok(movie);
        }

        public static async Task<IResult> CreateScreening(IRepository repository, int MovieID, int ScreenID)
        {
            Screening screening = await repository.AddScreening(MovieID, ScreenID);
            return TypedResults.Created("", screening);
        }

        public static async Task<IResult> GetAllScreenings(IRepository repository, int MovieID)
        {
            List<Screening> screenings = await repository.GetAllScreenings(MovieID);
            return TypedResults.Ok(screenings);
        }
    }
}
