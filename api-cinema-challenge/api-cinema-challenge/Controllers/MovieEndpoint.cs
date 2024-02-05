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

            movies.MapPost("/{id}", AddMovie);
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
                return TypedResults.BadRequest("Invalid input");
            }

            Movie newMovie = new Movie
            {
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                Runtime = movie.Runtime
            };

            var addedMovie = await repository.AddMovie(newMovie);

            return TypedResults.Created($"/{newMovie.Id}", addedMovie.ToDTO());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IMovieRepository repository)
        {
            var movies = await repository.GetAllMovies();
            List<MovieDTO> moviesDTO = new List<MovieDTO>();

            foreach (var mov in movies)
            {
                moviesDTO.Add(mov.ToDTO());
            }

            return TypedResults.Ok(moviesDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, int id, MoviePost movie)
        {
            if (movie == null)
            {
                return TypedResults.BadRequest("Invalid input");
            }

            var changedMovie = await repository.UpdateMovie(id, movie);
            if (changedMovie == null)
            {
                return TypedResults.NotFound($"Movie with id {id} was not found");
            }

            return TypedResults.Created($"{changedMovie.Id}", changedMovie.ToDTO());
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

            return TypedResults.Ok(deletedMovie.ToDTO());
        }
    }
}
