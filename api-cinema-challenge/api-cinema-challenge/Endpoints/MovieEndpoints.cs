using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Responses;
using api_cinema_challenge.ViewModels;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
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
            group.MapGet("/{id}/screenings", GetScreenings);
            group.MapPost("/", CreateMovie);
            group.MapPost("/{id}/screenings", CreateScreening);
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

                if (!movies.Any()) return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, "No movies found."));

                ApiResponse<IEnumerable<MovieDTO>> response = new ApiResponse<IEnumerable<MovieDTO>>(ApiStatus.Success, mapper.Map<IEnumerable<MovieDTO>>(movies));

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, IMapper mapper, int id)
        {
            try
            {
                IEnumerable<Screening> screenings = await repository.FindAll(s => s.MovieId == id);

                if (!screenings.Any()) return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, "No screenings found."));


                ApiResponse<IEnumerable<ScreeningDTO>> response = new ApiResponse<IEnumerable<ScreeningDTO>>(ApiStatus.Success, mapper.Map<IEnumerable<ScreeningDTO>>(screenings));

                return TypedResults.Ok(response);
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

                if (movie == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No movie with id:{id} was found."));
                }

                ApiResponse<MovieDTO> response = new ApiResponse<MovieDTO>(ApiStatus.Success, mapper.Map<MovieDTO>(movie));

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, IMapper mapper, IValidator<CreateMovie> validator, IValidator<CreateScreening> screeningValidator, CreateMovie entity)
        {
            try
            {
                var movieValidationResult = await validator.ValidateAsync(entity);

                if (!movieValidationResult.IsValid)
                {
                    return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, movieValidationResult.Errors));
                }

                if (entity.Screenings != null && entity.Screenings.Any())
                {
                    foreach (var screening in entity.Screenings)
                    {
                        var screeningValidationResult = await screeningValidator.ValidateAsync(screening);

                        if (!screeningValidationResult.IsValid)
                        {
                            return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, screeningValidationResult.Errors));
                        }
                    }
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

                Movie movie = await movieRepository.Add(newMovie);

                if (entity.Screenings != null && entity.Screenings.Any())
                {
                    foreach (var screening in entity.Screenings)
                    {
                        Screening newScreening = new Screening
                        {
                            ScreenNumber = screening.ScreenNumber,
                            Capacity = screening.Capacity,
                            StartsAt = screening.StartsAt,
                            MovieId = movie.Id,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                        };

                        await screeningRepository.Add(newScreening);
                    }
                }

                ApiResponse<MovieDTO> response = new ApiResponse<MovieDTO>(ApiStatus.Success, mapper.Map<MovieDTO>(movie));

                return TypedResults.Created($"https://localhost:7235/movies/{movie.Id}", response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, IRepository<Movie> movieRepository, IMapper mapper, IValidator<CreateScreening> validator, int id, CreateScreening entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, validationResult.Errors));
                }

                Movie movie = await movieRepository.Get(c => c.Id == id);

                if (movie == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No movie with id:{id} was found."));
                }

                Screening newScreening = new Screening
                {
                    ScreenNumber = entity.ScreenNumber,
                    Capacity = entity.Capacity,
                    StartsAt = entity.StartsAt,
                    MovieId = movie.Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };




                ApiResponse<ScreeningDTO> response = new ApiResponse<ScreeningDTO>(ApiStatus.Success, mapper.Map<ScreeningDTO>(newScreening));

                return TypedResults.Created($"https://localhost:7235/movies/{newScreening.Id}/screenings", response);
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
                if (movie == null) return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No movie with id:{id} was found."));

                await repository.Delete(movie);

                ApiResponse<MovieDTO> response = new ApiResponse<MovieDTO>(ApiStatus.Success, mapper.Map<MovieDTO>(movie));

                return TypedResults.Ok(response);
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
                    return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, validationResult.Errors));
                }

                Movie movie = await repository.Get(c => c.Id == id);
                if (movie == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No movie with id:{id} was found."));
                }

                movie.Title = entity.Title;
                movie.Description = entity.Description;
                movie.Rating = entity.Rating;
                movie.RuntimeMins = entity.RuntimeMins;
                movie.UpdatedAt = DateTime.UtcNow;

                await repository.Update(movie);

                ApiResponse<MovieDTO> response = new ApiResponse<MovieDTO>(ApiStatus.Success, mapper.Map<MovieDTO>(movie));

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

    }
}
