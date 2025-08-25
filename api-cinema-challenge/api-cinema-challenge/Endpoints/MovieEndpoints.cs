using api_cinema_challenge.DataTransfer.Requests;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");

            movies.MapPost("/", Create);
            movies.MapGet("/", GetAll);
            movies.MapPut("/{id}", Update);
            movies.MapDelete("/{id}", Delete);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Movie> repository, MoviePostRequest movie)
        {
            var newMovie = new Movie()
            {
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                Screenings = movie.screenings,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            await repository.Create(newMovie);
            return TypedResults.Created($"/{newMovie.Id}", newMovie);
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> repository)
        {
            var entities = await repository.GetAll();
            List<Object> results = new List<Object>();

            foreach (var entity in entities)
            {
                results.Add(new {
                    Title = entity.Title,
                    Rating = entity.Rating,
                    Description = entity.Description,
                    RuntimeMins = entity.RuntimeMins,
                    Screenings = entity.Screenings
                });
            }

            return TypedResults.Ok(results);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Update(IRepository<Movie> repository, int id, MoviePostRequest movie)
        {
            var entity = await repository.GetById(id);

            entity.Title = !string.IsNullOrEmpty(movie.Title) ? movie.Title : entity.Title;
            entity.Rating = movie.Rating;
            entity.Description = !string.IsNullOrEmpty(movie.Description) ? movie.Description : entity.Description;
            entity.RuntimeMins = movie.RuntimeMins;
            entity.Screenings = movie.screenings;
            entity.UpdatedAt = DateTime.UtcNow;

            var result = await repository.Update(entity);

            return result != null ? TypedResults.Ok(new {
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimeMins,
                Screenings = entity.Screenings,
                UpdatedAt = result.UpdatedAt
            }) : TypedResults.BadRequest("Couldn't save to the database?!");
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Delete(IRepository<Movie> repository, int id)
        {
            var entity = await repository.GetById(id);
            var result = await repository.Delete(entity);

            return result != null ? TypedResults.Ok(new {
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimeMins,
                Screenings = entity.Screenings,
                UpdatedAt = result.UpdatedAt
            }) : TypedResults.BadRequest("Object wasnt deleted?!");
        }
    }
}
