using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MoviesEndpoints
    {
        public static void ConfigureMovies(this WebApplication app)
        {
            var customers = app.MapGroup("/movies");

            customers.MapPost("/", Insert);
            customers.MapGet("/", GetAll);
            customers.MapPut("/{id}", Update);
            customers.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> Insert(IRepository<Movie> repository, IMapper mapper, MoviePostDTO movie)
        {
            try
            {
                Movie insert = new Movie()
                {
                    Title = movie.Title,
                    Rating = movie.Rating,
                    Description = movie.Description,
                    RuntimeMins = movie.RuntimeMins
                };

                await repository.Insert(insert);

                return TypedResults.Created($"https://localhost:7195/movies/{insert.Id}", insert);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> repository, IMapper mapper)
        {
            try
            {
                var movies = await repository.Get();

                var response = mapper.Map<List<MovieDTO>>(movies);

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Update(IRepository<Movie> repository, int id, MoviePostDTO movie)
        {
            try
            {
                var target = await repository.GetById(id);

                if (target == null)
                    return Results.NotFound();
                if (movie.Title != null)
                    target.Title = movie.Title;
                if (movie.Rating != null)
                    target.Rating = movie.Rating;
                if (movie.Description != null)
                    target.Description = movie.Description;
                if (movie.RuntimeMins.GetType() == typeof(Int32))
                    target.RuntimeMins = movie.RuntimeMins;
                target.UpdatedAt = DateTime.UtcNow;

                await repository.Update(target);

                return TypedResults.Created($"https://localhost:7195/movies/{target.Id}", target);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Delete(IRepository<Movie> repository, int id)
        {
            try
            {
                var target = await repository.GetById(id);

                if (await repository.Delete(id) != null)
                    return TypedResults.Ok(target);
                return TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
