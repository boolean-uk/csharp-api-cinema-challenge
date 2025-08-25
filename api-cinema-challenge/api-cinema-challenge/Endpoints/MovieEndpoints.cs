using api_cinema_challenge.DTOs.Customers;
using api_cinema_challenge.DTOs.Movies;
using api_cinema_challenge.DTOs.Screenings;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var moviesGroup = app.MapGroup("movies");

            moviesGroup.MapGet("/", GetMovies);
            moviesGroup.MapPost("/", AddMovie);
            moviesGroup.MapPut("/{id}", UpdateMovie);
            moviesGroup.MapDelete("/{id}", DeleteMovie);

            moviesGroup.MapGet("/{id}/screenings", GetScreeningsForMovie);
            moviesGroup.MapPost("/{id}/screenings", AddScreeningToMovie);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository, ClaimsPrincipal user)
        {
            var movies = await repository.Get();

            var response = new
            {
                status = "success",
                data = movies.Select(movie => new MovieDTO
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Rating = movie.Rating,
                    Description = movie.Description,
                    RuntimeMins = movie.RuntimeMins,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt
                }).ToList()
            };

            return TypedResults.Ok(response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> AddMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, MoviePost model, ClaimsPrincipal user)
        {
            Movie entity = new Movie();
            entity.Title = model.Title;
            entity.Rating = model.Rating;
            entity.Description = model.Description;
            entity.RuntimeMins = model.RuntimeMins;

            await movieRepository.Insert(entity);

            if (model.screenings != null && model.screenings.Count > 0)
            {
                foreach (var screening in model.screenings)
                {
                    Screening newScreening = new Screening
                    {
                        MovieId = entity.Id,
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt
                    };
                    await screeningRepository.Insert(newScreening);
                }
            }

            var response = new
            {
                status = "success",
                data = new MovieDTO
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Rating = entity.Rating,
                    Description = entity.Description,
                    RuntimeMins = entity.RuntimeMins,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Created($"https://localhost:7239/movies/{entity.Id}", response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MoviePut model, ClaimsPrincipal user)
        {
            var entity = await repository.GetById(id);

            if (model.Title != null) entity.Title = model.Title;
            if (model.Rating != null) entity.Rating = model.Rating;
            if (model.Description != null) entity.Description = model.Description;
            if (model.RuntimeMins.HasValue) entity.RuntimeMins = model.RuntimeMins.Value;
            entity.UpdatedAt = DateTime.UtcNow;

            await repository.Update(entity);

            var updatedEntity = await repository.GetById(id);

            var response = new
            {
                status = "success",
                data = new MovieDTO
                {
                    Id = updatedEntity.Id,
                    Title = updatedEntity.Title,
                    Rating = updatedEntity.Rating,
                    Description = updatedEntity.Description,
                    RuntimeMins = updatedEntity.RuntimeMins,
                    CreatedAt = updatedEntity.CreatedAt,
                    UpdatedAt = updatedEntity.UpdatedAt
                }
            };

            return TypedResults.Created($"https://localhost:7239/movies/{entity.Id}", response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, int id, ClaimsPrincipal user)
        {
            var entity = await movieRepository.GetById(id);

            await movieRepository.Delete(id);

            var screenings = await screeningRepository.Get();
            screenings = screenings.Where(s => s.MovieId == id);
            foreach (var screening in screenings)
            {
                await screeningRepository.Delete(screening.Id);
            }

            var response = new
            {
                status = "success",
                data = new MovieDTO
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Rating = entity.Rating,
                    Description = entity.Description,
                    RuntimeMins = entity.RuntimeMins,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Ok(response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> GetScreeningsForMovie(IRepository<Movie> repository, int id, ClaimsPrincipal user)
        {
            var movie = await repository.GetByIdWithIncludes(id, m => m.Screenings);

            var response = new
            {
                status = "success",
                data = new MovieWithScreenings
                {
                    Id = movie.Id,
                    Screenings = movie.Screenings.Select(s => new ScreeningsForMovie
                    {
                        Id = s.Id,
                        ScreenNumber = s.ScreenNumber,
                        Capacity = s.Capacity,
                        StartsAt = s.StartsAt,
                        CreatedAt = s.CreatedAt,
                        UpdatedAt = s.UpdatedAt
                    }).ToList()
                }
            };

            return TypedResults.Ok(response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> AddScreeningToMovie(IRepository<Screening> repository, int id, ScreeningPost model, ClaimsPrincipal user)
        {
            Screening entity = new Screening();
            entity.MovieId = id;
            entity.ScreenNumber = model.ScreenNumber;
            entity.Capacity = model.Capacity;
            entity.StartsAt = model.StartsAt;

            await repository.Insert(entity);

            var response = new
            {
                status = "success",
                data = new ScreeningsForMovie
                {
                    Id = entity.Id,
                    ScreenNumber = entity.ScreenNumber,
                    Capacity = entity.Capacity,
                    StartsAt = entity.StartsAt,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Created($"https://localhost:7239/movies/{entity.Id}/screenings", response);
        }
    }
}
