using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapPost("", AddMovie);
            movies.MapGet("", GetAllMovies);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddMovie(IRepository<Movie> repository, MoviePost movie)
        {
            if (movie == null)
            {
                return TypedResults.BadRequest("Invalid input: missing movie");
            }
            if (string.IsNullOrEmpty(movie.Title))
            {
                return TypedResults.BadRequest("Invalid input: please enter a title");
            }
            if (string.IsNullOrEmpty(movie.Rating))
            {
                return TypedResults.BadRequest("Invalid input: please enter a rating");
            }
            if (string.IsNullOrEmpty(movie.Description))
            {
                return TypedResults.BadRequest("Invalid input: please enter a description");
            }
            if (movie.Runtime == null)
            {
                return TypedResults.BadRequest("Invalid input: please enter a runtime");
            }

            Movie newMovie = new Movie
            {
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                Runtime = (int)movie.Runtime
            };

            if (movie.Screenings != null)
            {
                foreach (var screening in movie.Screenings)
                {
                    if (screening == null)
                    {
                        return TypedResults.BadRequest("Invalid input: missing screening");
                    }
                    if (screening.ScreenNumber == null)
                    {
                        return TypedResults.BadRequest("Invalid input: please enter a screen number");
                    }
                    if (screening.Capacity == null)
                    {
                        return TypedResults.BadRequest("Invalid input: please enter a capactiy");
                    }
                    if (screening.StartsAt == null)
                    {
                        return TypedResults.BadRequest("Invalid input: please enter a starting time");
                    }

                    var newScreening = new Screening
                    {
                        ScreenNumber = screening.ScreenNumber.Value,
                        Capacity = screening.Capacity.Value,
                        AvailableSeats = screening.Capacity.Value,
                        StartsAt = screening.StartsAt.Value,
                        MovieId = newMovie.Id,
                        Movie = newMovie
                    };

                    newMovie.Screenings.Add(newScreening);
                }
            }

            var addedMovie = await repository.Add(newMovie);

            return TypedResults.Created($"/{newMovie.Id}", Movie.ToDTO(addedMovie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.GetAll();

            return TypedResults.Ok(Movie.ToDTO(movies));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MoviePut movie)
        {
            if (movie == null)
            {
                return TypedResults.BadRequest("Invalid input: missing movie");
            }

            Movie? oldMovie = await repository.Get(id);

            if (oldMovie == null)
            {
                return TypedResults.NotFound($"Movie with id {id} was not found");
            }

            if (movie.Title != null) { oldMovie.Title = movie.Title; }
            if (movie.Rating != null) { oldMovie.Rating = movie.Rating; }
            if (movie.Description != null) { oldMovie.Description = movie.Description; }
            if (movie.Runtime != null) { oldMovie.Runtime = (int)movie.Runtime; }
            oldMovie.UpdatedAt = DateTime.UtcNow;

            var changedMovie = await repository.Update(oldMovie);

            return TypedResults.Created($"/{id}", Movie.ToDTO(changedMovie));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var deletedMovie = await repository.Delete(id);
            if (deletedMovie == null)
            {
                return TypedResults.NotFound($"Movie with id {id} was not found");
            }

            return TypedResults.Ok(Movie.ToDTO(deletedMovie));
        }
    }
}