using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {

        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("movies");

            group.MapGet("/", GetMovies);
            group.MapGet("/{id}", GetMovieById);
            group.MapPost("/", CreateMovie);
            group.MapDelete("/{id}", DeleteMovie);
            group.MapPut("/{id}", UpdateMovie);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Movie> movies = await repository.GetAll();

                if (!movies.Any()) return TypedResults.NotFound();

                return TypedResults.Ok(mapper.Map<IEnumerable<MovieDTO>>(movies));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetMovieById(IRepository<Movie> repository, IMapper mapper, int id)
        {
            try
            {
                Movie movie = await repository.Get(c => c.Id == id);

                if (movie == null) return TypedResults.NotFound($"No movie with id:{id} was found.");

                return TypedResults.Ok(mapper.Map<MovieDTO>(movie));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, IMapper mapper, IValidator<CreateMovie> validator, CreateMovie entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(validationResult.Errors);
                }

                Movie newMovie = new Movie
                {
                    Title = entity.Title,
                    Rating = entity.Rating,
                    Description = entity.Description,
                    RuntimeMins = entity.RuntimeMins,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };


                Movie movie = await repository.Add(newMovie);

                return TypedResults.Created($"https://localhost:7235/movies/", mapper.Map<MovieDTO>(movie));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, IMapper mapper, int id)
        {
            try
            {
                Movie movie = await repository.Get(c => c.Id == id);
                if (movie == null) return TypedResults.NotFound($"No movie with id:{id} was found.");

                await repository.Delete(movie);

                return TypedResults.Ok(mapper.Map<MovieDTO>(movie));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, IMapper mapper, IValidator<UpdateMovie> validator, int id, UpdateMovie entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(validationResult.Errors);
                }

                Movie movie = await repository.Get(c => c.Id == id);
                if (movie == null) return TypedResults.NotFound($"No movie with id:{id} was found.");

                movie.Title = entity.Title;
                movie.Description = entity.Description;
                movie.Rating = entity.Rating;
                movie.RuntimeMins = entity.RuntimeMins;
                movie.UpdatedAt = DateTime.UtcNow;

                await repository.Update(movie);

                return TypedResults.Ok(mapper.Map<MovieDTO>(movie));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

    }
}
