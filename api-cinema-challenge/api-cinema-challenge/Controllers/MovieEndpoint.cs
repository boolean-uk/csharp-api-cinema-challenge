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
                Runtime = (int)movie.Runtime
            };

            if (movie.Screenings != null)
            {
                foreach (var screening in movie.Screenings)
                {
                    var newScreening = new Screening
                    {
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                        MovieId = newMovie.Id,
                        Movie = newMovie
                    };

                    newMovie.Screenings.Add(newScreening);
                }
            }

            var addedMovie = await repository.AddMovie(newMovie);
            var movieDTO = addedMovie.ToDTO();
            var responseDTO = new MovieResponseDTO { Status = "success", Data = movieDTO };

            return TypedResults.Created($"/{newMovie.Id}", responseDTO);
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
            var responseDTO = new MovieResponseListDTO { Status = "success", Data = moviesDTO };

            return TypedResults.Ok(responseDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, int id, MoviePut movie)
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

            var movieDTO = new MovieResponseDTO { Status="success", Data=changedMovie.ToDTO() };

            return TypedResults.Created($"{changedMovie.Id}", movieDTO);
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

            var movieDTO = new MovieResponseDTO { Status="success", Data=deletedMovie.ToDTO() };

            return TypedResults.Ok(movieDTO);
        }
    }
}
