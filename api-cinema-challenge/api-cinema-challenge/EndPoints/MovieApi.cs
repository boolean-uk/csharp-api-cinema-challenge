using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screen;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication application)
        {
            application.MapGet("/movies", GetMovies);
            application.MapPost("/movies", AddMovie);
            application.MapPut("/movies/{id}", UpdateMovie);
            application.MapDelete("/movies/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            try
            {
                List<Movie> movies = (List<Movie>)repository.GetMovies();
                if (movies.Any())
                {
                    Payload<List<Movie>> payload = new Payload<List<Movie>>();
                    payload.data = movies;
                    return Results.Ok(payload);
                }
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddMovie(MovieScreenCreate moviePost, IRepository repository)
        {
            try
            {
                Movie movie = new Movie();
                movie.title = moviePost.title;
                movie.rating = moviePost.rating;
                movie.description = moviePost.description;
                movie.runtimeMins = moviePost.runtimeMins;
                movie.createdAt = DateTime.UtcNow;
                movie.updatedAt = DateTime.UtcNow;
                Payload<Movie> payload = new Payload<Movie>();
                payload.data = movie;

                if (repository.AddMovie(movie))
                {
                    foreach (ScreenPost item in moviePost.screenings)
                    {
                        Screen screen = new Screen();
                        screen.movieId = movie.id;
                        screen.screenNumber = item.screenNumber;
                        screen.capacity = item.capacity;
                        screen.startsAt = item.startsAt;
                        screen.createdAt = DateTime.UtcNow;
                        screen.updatedAt = DateTime.UtcNow;
                        repository.AddScreen(screen);
                    }

                    return Results.Created("https://localhost:7195/customers", payload);
                }

                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateMovie(int id, MoviePut moviePut, IRepository repository)
        {
            try
            {
                var targetMovie = repository.GetMovie(id);
                targetMovie.title = moviePut.title != null ? moviePut.title : targetMovie.title;
                targetMovie.rating = moviePut.rating != null ? moviePut.rating : targetMovie.rating;
                targetMovie.description = moviePut.description != null ? moviePut.description : targetMovie.description;
                targetMovie.runtimeMins = moviePut.runtimeMins != null ? moviePut.runtimeMins : targetMovie.runtimeMins;
                targetMovie.updatedAt = DateTime.UtcNow;

                if (repository.UpdateMovie(id, targetMovie))
                {
                    Payload<Movie> payload = new Payload<Movie>();
                    payload.data = targetMovie;
                    return Results.Ok(payload);
                }
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteMovie(int id, IRepository repository)
        {
            try
            {
                var targetMovie = repository.GetMovie(id);
                if (repository.DeleteMovie(id))
                {
                    Payload<Movie> payload = new Payload<Movie>();
                    payload.data = targetMovie;
                    return Results.Ok(payload);
                }
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
