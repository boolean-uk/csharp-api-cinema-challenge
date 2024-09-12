using api_cinema_challenge.DTOs;
using api_cinema_challenge.DTOs.Customer;
using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", AddCustomer);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customer/{id}", DeleteCustomer);

            app.MapGet("/movies", GetMovies);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddCustomer(IRepository<Customer> custRepo, CustomerPostModel model)
        {
            Customer customer = new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone, UpdatedAt = DateTime.UtcNow };
            
            var newCustomer = await custRepo.Create(customer);
            Payload<Customer> payload = new Payload<Customer> { Data = newCustomer };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> custRepo)
        {
            var customer = await custRepo.GetAll();
            Payload<List<Customer>> payload = new Payload<List<Customer>>() { Data = customer.ToList() };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> custRepo, int id, CustomerPutModel model)
        {
            try
            {
                var customers = await custRepo.GetAll();
                var entity = customers.FirstOrDefault(c => c.Id == id);

                if (entity != null)
                {
                    entity.Name = !string.IsNullOrEmpty(model.Name) ? model.Name : entity.Name;
                    entity.Email = !string.IsNullOrEmpty(model.Email) ? model.Email : entity.Email;
                    entity.Phone = !string.IsNullOrEmpty(model.Phone) ? model.Phone : entity.Phone;
                    entity.UpdatedAt = DateTime.UtcNow;
                    var result = await custRepo.Update(entity);

                    Payload<Customer> payload = new Payload<Customer>() { Data = result };
                    return TypedResults.Ok(payload);
                }
                else return Results.NotFound("Customer does not exist");
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> custRepo, int id)
        {
            try
            {
                var deletedCustomer = await custRepo.Delete(id);

                if (deletedCustomer != null)
                {
                    Payload<Customer> payload = new Payload<Customer>() { Data = deletedCustomer };
                    return TypedResults.Ok(payload);
                }
                return TypedResults.NotFound("Customer does not exist");
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> movieRepo)
        {
            var movies = await movieRepo.GetAll();
            Payload<List<Movie>> payload = new Payload<List<Movie>>() { Data = movies.ToList() };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddMovie(IRepository<Movie> movieRepo, MoviePostModel model)
        {
            Movie movie = new Movie() 
            { 
                Title = model.Title, 
                Rating = model.Rating, 
                Description = model.Description, 
                RuntimeMins = model.RuntimeMins, 
                UpdatedAt = DateTime.UtcNow 
            };

            var newMovie = await movieRepo.Create(movie);
            Payload<Movie> payload = new Payload<Movie> { Data = newMovie };

            return TypedResults.Ok(payload);
        }

    }
}
