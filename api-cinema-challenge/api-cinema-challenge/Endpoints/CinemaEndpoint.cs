using System.Runtime.InteropServices;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repsitories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            app.MapGet("/movies", GetMovies);
            app.MapPost("/movies", AddMovie);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);

            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", AddCustomer);
            app.MapPut("/customer/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);

            app.MapGet("movies/{id}/screenings", GetScreenings);
            app.MapPost("movies/{id}/screenings", AddScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            GetAllResponse<DTOMovie> movieResponse = new GetAllResponse<DTOMovie>();

            foreach(var movie in await repository.GetMovies())
            {
                movieResponse.Response.Add(new DTOMovie() {
                    ID = movie.Id, 
                    Title = movie.Title, 
                    Description = movie.Description, 
                    RuntimeMins = movie.RuntimeMins, 
                    Rating = movie.Rating, 
                    CreatedAt = movie.CreatedAt, 
                    UpdatedAt = movie.UpdatedAt 
                });
            }

            return TypedResults.Ok(movieResponse);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddMovie(IRepository repository, MoviePostModel model)
        {
            Movie movie = await repository.AddMovie(new Movie { 
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description, 
                RuntimeMins = model.RuntimeMins, 
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            return TypedResults.Created("", new DTOMovie()
            {
                ID = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            });
        }
        [Route("/movies/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, MoviePostModel model) 
        {
            Movie movie = await repository.UpdateMovie(new Movie
            {
                Id = id,
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = model.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            return TypedResults.Created("", new DTOMovie()
            {
                ID = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            });
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            Movie movie = await repository.DeleteMovie(id);
            return TypedResults.Ok( new DTOMovie()
            {
                ID = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            });
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            GetAllResponse<Customer> customerResponse = new GetAllResponse<Customer>();

            foreach (var customer in await repository.GetCustomers())
            {
                customerResponse.Response.Add(customer);
            }

            return TypedResults.Ok(customerResponse);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddCustomer(IRepository repository, CustomerPostModel model)
        {
            Customer customer = await repository.AddCustomer(new Customer
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            return TypedResults.Created("", customer);
        }
        [Route("/customers/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPostModel model)
        {
            Customer customer = await repository.UpdateCustomer(new Customer
            {
                Id = id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            return TypedResults.Created("", customer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            Customer customer = await repository.DeleteCustomer(id);
            return TypedResults.Ok( customer);
        }


        [Route("movies/{id}/screenings")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            GetAllResponse<DTOScreening> screeningResponse = new GetAllResponse<DTOScreening>();

            foreach (var screening in await repository.GetScreenings(id))
            {
                screeningResponse.Response.Add(new DTOScreening() { 
                    Id = screening.Id, 
                    ScreenNumber = screening.Id, 
                    Capacity = screening.Capacity, 
                    StartsAt = screening.StartsAt, 
                    CreatedAt = screening.CreatedAt, 
                    UpdatedAt = screening.UpdatedAt
                });
            }

            return TypedResults.Ok(screeningResponse);
        }
        [Route("/movies/{id}/screenings")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddScreening(IRepository repository, int id, ScreeningPostModel model) 
        {
            Screening screening = await repository.AddScreening(new Screening()
            {
                MovieId = id,
                ScreenNumber = model.ScreenNumber,
                Capacity = model.Capacity,
                StartsAt = new DateTime(model.year, model.month, model.day, model.hour, model.minute, 0, DateTimeKind.Utc),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            return TypedResults.Created("", new DTOScreening()
            {
                Id = screening.Id,
                ScreenNumber = screening.Id,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt
            });

        }
    }
}
