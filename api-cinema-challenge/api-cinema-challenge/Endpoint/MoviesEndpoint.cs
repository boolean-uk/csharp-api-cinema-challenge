using api_cinema_challenge.Models.DatabaseModels;
using api_cinema_challenge.Models.Dto.GenericDto;
using api_cinema_challenge.Models.Input;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoint
{
    public static class MoviesEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);

            movieGroup.MapPost("/{id}/screenings", CreateScreening);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MovieInput input)
        {
            var movies = await repository.GetAll();
            DateTime creationTime = DateTime.UtcNow;

            var entity = new Movie()
            {
                Id = (movies.Count() == 0 ? 0 : movies.Max(patient => patient.Id) + 1),
                Title = input.Title,
                Rating = input.Rating,
                Description = input.Description,
                Runtime = input.Runtime,
                CreatedAt = creationTime,
                UpdateddAt = creationTime
            };
            repository.Insert(entity);
            return TypedResults.Created($"/{entity.Id}", entity);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            var result = await repository.GetAll();
            Payload<IEnumerable<Movie>> payload = new Payload<IEnumerable<Movie>>();
            payload.data = result;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieInput input)
        {
            var entity = await repository.GetById(id);
            if (entity == null)
            {
                return TypedResults.NotFound(id);
            }

            DateTime updateTime = DateTime.UtcNow;

            entity.Title = input.Title != null ? input.Title : entity.Title;
            entity.Rating = input.Rating != null ? input.Rating : entity.Rating;
            entity.Description = input.Description != null ? input.Description : entity.Description;
            entity.Runtime = input.Runtime != null ? input.Runtime : entity.Runtime;
            entity.UpdateddAt = updateTime;
            repository.Update(entity);
            return TypedResults.Created($"/{entity.Id}", entity);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var movie = await repository.GetById(id);
            if (movie == null)
            {
                return TypedResults.NotFound("Customer not found.");
            }
            var result = repository.Delete(id);
            return result != null ? TypedResults.Ok(result) : Results.NotFound();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, int id, ScreeningInput input)
        {
            var screenings = await repository.GetAll();
            DateTime creationTime = DateTime.UtcNow;

            var entity = new Screening()
            {
                Id = (screenings.Count() == 0 ? 0 : screenings.Max(patient => patient.Id) + 1),
                MovieId = id,
                ScreenNumber = input.ScreenNumber,
                Capacity = input.Capacity,
                StartsAt = input.StartsAt,
                CreatedAt = creationTime,
                UpdateddAt = creationTime
            };
            repository.Insert(entity);
            return TypedResults.Created($"/{entity.Id}", entity);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, int id)
        {
            var result = await repository.GetAll();
            Payload<IEnumerable<Screening>> payload = new Payload<IEnumerable<Screening>>();
            payload.data = result.Where(p=>p.MovieId == id);
            return TypedResults.Ok(payload);
        }
    }
}
