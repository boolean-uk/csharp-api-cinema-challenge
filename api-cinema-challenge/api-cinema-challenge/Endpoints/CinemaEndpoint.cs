using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", CreateCustomer);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);

            app.MapGet("/movies", GetMovies);
            app.MapPost("/movies", CreateMovie);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);

            app.MapGet("/movies/{movieId}/screenings", GetScreenings);
            app.MapPost("/movies/{movieId}/screenings", CreateScreening);

        }

        [Authorize]
        private static async Task<IResult> CreateScreening(IRepository repository, int movieId, ScreeningPost screeningPost)
        {
            var entity = await repository.CreateScreening(movieId, screeningPost);
            if (entity == null) return TypedResults.BadRequest();
            ScreeningGet result = ScreeningFactory.NewScreeningGet(entity);
            return TypedResults.Created($"movies/{movieId}/screenings/{entity.Id}", result);
        }
        [Authorize]
        private static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            var response = await repository.GetScreenings(movieId);
            List<ScreeningGet> results = new List<ScreeningGet>();
            foreach (var item in response)
            {
                results.Add(ScreeningFactory.NewScreeningGet(item));
            }
            return TypedResults.Ok(results);
        }
        [Authorize]
        private static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var entity = await repository.DeleteMovie(id);
            return TypedResults.Ok(entity);
        }
        [Authorize]
        private static async Task<IResult> UpdateMovie(IRepository repository, int id, MoviePut movie)
        {
            var entity = await repository.UpdateMovie(id, movie);
            return TypedResults.Created($"/customers/{id}", entity);
        }
        [Authorize]
        private static async Task<IResult> CreateMovie(IRepository repository, MoviePost movie)
        {
            var entity = await repository.CreateMovie(movie);
            if (entity == null) return TypedResults.BadRequest();
            MovieGet result = MovieFactory.NewMovieGet(entity);
            return TypedResults.Created($"/movies/{entity.Id}", result);
        }
        [Authorize]
        private static async Task<IResult> GetMovies(IRepository repository)
        {
            var response = await repository.GetMovies();
            List<MovieGet> results = new List<MovieGet>();
            foreach (var item in response)
            {
                results.Add(MovieFactory.NewMovieGet(item));
            }
            return TypedResults.Ok(results);
        }
        [Authorize]
        private static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var entity = await repository.DeleteCustomer(id);
            return TypedResults.Ok(entity);
        }
        [Authorize]
        private static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPut customer)
        {
            var entity = await repository.UpdateCustomer(id, customer);
            return TypedResults.Created($"/customers/{id}", entity);
        }
        [Authorize]
        private static async Task<IResult> CreateCustomer(IRepository repository, CustomerPost customer)
        {
            var entity = await repository.CreateCustomer(customer);
            if (entity == null) return TypedResults.BadRequest();
            CustomerGet result = new CustomerGet()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
            };
            return TypedResults.Created($"/customers/{entity.Id}", result);
        }
        [Authorize]
        private static async Task<IResult> GetCustomers(IRepository repository)
        {
            var response = await repository.GetCustomers();
            List<CustomerGet> results = new List<CustomerGet>();
            foreach (var item in response)
            {
                CustomerGet customer = new CustomerGet();
                customer.Id = item.Id;
                customer.Name = item.Name;
                customer.Email = item.Email;
                customer.Phone = item.Phone;
                customer.CreatedAt = item.CreatedAt;
                customer.UpdatedAt = item.UpdatedAt;
                results.Add(customer);
            }
            return TypedResults.Ok(results);
        }
    }
}
