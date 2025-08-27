using api_cinema_challenge.DTOs.Customers;
using api_cinema_challenge.DTOs.Movies;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movie = app.MapGroup("/movies");

            movie.MapPost("/", Create);
            movie.MapGet("/", GetAll);
            movie.MapPut("/{id}", UpdateMovie);
            movie.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> movieRepository)
        {
            var results = await movieRepository.Get();

            return TypedResults.Ok(results);
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> Create(IRepository<Movie> movieRepository, MoviePostPut model)
        {
            Movie movie = new Movie()
            {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = model.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var entity = await movieRepository.Insert(movie);


            return TypedResults.Created($"", entity);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> movieRepository, int id, MoviePostPut model)
        {
            var resultGet = await movieRepository.GetOne(id);
            resultGet.Title = model.Title;
            resultGet.Rating = model.Rating;
            resultGet.Description = model.Description;
            resultGet.RuntimeMins = model.RuntimeMins;
            resultGet.UpdatedAt = DateTime.UtcNow;

            var result = await movieRepository.Update(resultGet);
            return TypedResults.Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> Delete(IRepository<Movie> movieRepository, int id)
        {
            var result = await movieRepository.Delete(id);
            return TypedResults.Ok(result);
        }
    }
}
