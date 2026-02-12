using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.GenericRepositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");
            movies.MapPost("/", CreateMovie);
            movies.MapGet("/", GetAllMovies);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
        }

        // Create a Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(Movie movie, IRepository<Movie> repository)
        {
            await repository.AddAsync(movie);
            return TypedResults.Created($"/movies/{movie.Id}", new { status = "success", data = movie });
        }


        // Get all Movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.GetAllAsync();
            return TypedResults.Ok(new { status = "success", data = movies });
        }

        // Update a Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(int id, Movie movie, IRepository<Movie> repository)
        {
            var existingMovie = await repository.GetByIdAsync(id);
            if (existingMovie == null)
                return TypedResults.NotFound();

            existingMovie.Title = movie.Title;
            existingMovie.Rating = movie.Rating;
            existingMovie.Description = movie.Description;
            existingMovie.RuntimeMins = movie.RuntimeMins;

            await repository.UpdateAsync(existingMovie);
            return TypedResults.Created($"/movies/{id}", new { status = "success", data = existingMovie });
        }

        // Delete a Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(int id, IRepository<Movie> repository)
        {
            var movie = await repository.GetByIdAsync(id);
            if (movie == null)
                return TypedResults.NotFound();

            await repository.DeleteAsync(id);
            return TypedResults.Ok(new { status = "success", data = movie });
        }
    }
}
