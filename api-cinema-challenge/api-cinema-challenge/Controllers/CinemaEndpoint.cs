using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace api_cinema_challenge.Controllers

{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoints(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("/");

            cinemaGroup.MapPost("customers", CreateCustomer);
            cinemaGroup.MapGet("customers", GetCustomers);
            cinemaGroup.MapPut("customers", UpdateCustomer);
            cinemaGroup.MapDelete("customers", DeleteCustomer);

            cinemaGroup.MapPost("movies", CreateMovie);
            cinemaGroup.MapGet("movies", GetMovies);
            cinemaGroup.MapPut("movies", UpdateMovie);
            cinemaGroup.MapDelete("movies", DeleteMovie);

            cinemaGroup.MapPost("movies/{id}/screenings", CreateScreening);
            cinemaGroup.MapGet("movies/{id}/screenings", GetScreenings);
        }

        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPost customer)
        {
            if (customer == null)
            {
                return TypedResults.BadRequest();
            }
            var newCustomer = await repository.CreateCustomer(customer);
            var customerDTO = new CustomerDTO()
            {
                Id = newCustomer.Id,
                Name = newCustomer.Name,
                Email = newCustomer.Email,
                Phone = newCustomer.Phone,
                CreatedAt = newCustomer.CreatedAt,
                UpdatedAt = newCustomer.UpdatedAt
            };
            return TypedResults.Created($"{customerDTO.Name}", customerDTO);
        }
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            return TypedResults.Ok(await repository.GetCustomers());
        }
        public static async Task<IResult> UpdateCustomer(IRepository repository, CustomerPut customer, int id)
        {
            var updated = await repository.UpdateCustomer(customer, id);
            var customerDTO = new CustomerDTO()
            {
                Id = updated.Id,
                Name = updated.Name,
                Email = updated.Email,
                Phone = updated.Phone,
                CreatedAt = updated.CreatedAt,
                UpdatedAt = updated.UpdatedAt
                
            };
            return TypedResults.Created($"{customerDTO.Name}", customerDTO);
        }
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            return TypedResults.Ok(await repository.DeleteCustomer(id));
        }


        public static async Task<IResult> CreateMovie(IRepository repository, MoviePost movie)
        {
            if (movie == null)
            {
                return TypedResults.BadRequest();
            }
            var newMovie = await repository.CreateMovie(movie);
            var movieDTO = new MovieDTO()
            {
                Id = newMovie.Id,
                Title = newMovie.Title,
                Rating = newMovie.Rating,
                Description = newMovie.Description,
                RuntimeMins = newMovie.RuntimeMins,
                CreatedAt = newMovie.CreatedAt,
                UpdatedAt = newMovie.UpdatedAt,
            };
            return TypedResults.Created($"{movieDTO.Title}", movieDTO);
        }

        public static async Task<IResult> GetMovies(IRepository repository)
        {
            return TypedResults.Ok(await repository.GetMovies());
        }
        public static async Task<IResult> UpdateMovie(IRepository repository, MoviePut movie, int id)
        {
            var updated = await repository.UpdateMovie(movie, id);
            var movieDTO = new MovieDTO()
            {
                Id =updated.Id,
                Title = updated.Title,
                Rating = updated.Rating,
                Description = updated.Description,
                RuntimeMins = updated.RuntimeMins,
                CreatedAt = updated.CreatedAt,
                UpdatedAt = updated.UpdatedAt
            };
            return TypedResults.Created($"{movieDTO.Title}", movieDTO);
        }

        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            return TypedResults.Ok(await repository.DeleteMovie(id));
        }

        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPost screening, int movieId)
        {
            if (screening == null)
            {
                return TypedResults.BadRequest();
            }
            var newScreening = await repository.CreateScreening(screening, movieId);
            var screeningDTO = new ScreeningDTO()
            {
                Id = newScreening.Id,
                ScreenNumber = newScreening.ScreenNumber,
                Capacity = newScreening.Capacity,
                StartsAt = newScreening.StartsAt,
                CreatedAt = newScreening.CreatedAt,
                UpdatedAt = newScreening.UpdatedAt
            };
            return TypedResults.Created($"{screeningDTO.ScreenNumber}", screeningDTO);
        }

        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            return TypedResults.Ok(await repository.GetScreenings(id));
        }
    }
} 
