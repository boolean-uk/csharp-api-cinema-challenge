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
        public static async Task<IResult> AddMovie(IMovieRepository repository, MoviePost movie)
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
                        StartsAt = screening.StartsAt.Value,
                        MovieId = newMovie.Id,
                        Movie = newMovie
                    };

                    newMovie.Screenings.Add(newScreening);
                }
            }

            var addedMovie = await repository.AddMovie(newMovie);

            return TypedResults.Created($"/{newMovie.Id}", Movie.ToDTO(addedMovie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IMovieRepository repository)
        {
            var movies = await repository.GetAllMovies();

            return TypedResults.Ok(Movie.ToDTO(movies));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, int id, MoviePut movie)
        {
            if (movie == null)
            {
                return TypedResults.BadRequest("Invalid input: missing movie");
            }

            var changedMovie = await repository.UpdateMovie(id, movie);
            if (changedMovie == null)
            {
                return TypedResults.NotFound($"Movie with id {id} was not found");
            }

            return TypedResults.Created($"/{changedMovie.Id}", Movie.ToDTO(changedMovie));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            var deletedMovie = await repository.DeleteMovie(id);
            if (deletedMovie == null)
            {
                return TypedResults.NotFound($"Movie with id {id} was not found");
            }

            return TypedResults.Ok(Movie.ToDTO(deletedMovie));
        }
    }
}
