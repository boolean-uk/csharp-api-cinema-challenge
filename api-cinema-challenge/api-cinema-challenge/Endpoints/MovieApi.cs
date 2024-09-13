using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movies = app.MapGroup("movies");
            movies.MapGet("/", GetMovies);
            movies.MapGet("/{id}", GetMovieById);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
            movies.MapPost("/", CreateMovie);
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            Response<IEnumerable<MovieDTO>> response = new();
            var movies = await repository.GetAll();
            var movieResponse = movies.Select(m => new MovieDTO(m));
            response.Data = movieResponse;
            return TypedResults.Ok(response);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovieById(IRepository<Movie> repository, int id)
        {
            Response<IEnumerable<MovieDTO>> response = new();
            List<MovieDTO> movieResponse = new();
            var movie = await repository.GetById(id);
            movieResponse.Add(new MovieDTO(movie));
            response.Data = movieResponse;
            return TypedResults.Ok(response);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MoviePayload model)
        {
            Response<IEnumerable<MovieDTO>> response = new();
            List<MovieDTO> movieResponse = new();

            var updateMovie = await repository.GetById(id);
            updateMovie.Title = model.Title;
            updateMovie.Rating = model.Rating;
            updateMovie.Description = model.Description;
            updateMovie.DurationMinutes = model.DurationMinutes;
            updateMovie.UpdatedAt = DateTime.UtcNow;

            updateMovie = await repository.Update(updateMovie);

            movieResponse.Add(new MovieDTO(updateMovie));
            response.Data = movieResponse;
            return TypedResults.Ok(response);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            Response<IEnumerable<MovieDTO>> response = new();
            List<MovieDTO> movieResponse = new();
            var deleteMovie = await repository.Delete(id);
            movieResponse.Add(new MovieDTO(deleteMovie));
            response.Data = movieResponse;
            return TypedResults.Ok(response);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MoviePayload model)
        {
            var movies = await repository.GetAll();

            if (movies.Any(m => m.Title == model.Title))
            {
                return TypedResults.BadRequest($"{model.Title} already exists");
            };

            Response<IEnumerable<MovieDTO>> response = new();
            List<MovieDTO> movieResponse = new();
            var addMovie = new Movie() { Title = model.Title, Rating = model.Rating, Description = model.Description, DurationMinutes = model.DurationMinutes, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            addMovie = await repository.Add(addMovie);
            movieResponse.Add(new MovieDTO(addMovie));
            response.Data = movieResponse;
            return TypedResults.Ok(response);

        }


    }
}
