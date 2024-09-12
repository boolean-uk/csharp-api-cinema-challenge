using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModelsMovie;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.RegularExpressions;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapPost("/Create", CreateMovie);
            movies.MapGet("/GetAll", GetMovies);
            movies.MapPut("/Update{id}", UpdateMovie);
            movies.MapDelete("/Delete{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, InputCreateMovieDTO data)
        {
            try
            {
                //Create new movie
                Movie movie = new Movie()
                {
                    Title = data.Title,
                    Rating = data.Rating,
                    Description = data.Description,
                    RuntimeMins = data.RuntimeMins,
                    CreatedAt = DateTime.UtcNow
                };
                movie.UpdatedAt = movie.CreatedAt;
                var result = await repository.AddMovie(movie);

                if (data.screenings != null)
                {
                    CultureInfo culture = CultureInfo.InvariantCulture;
                    foreach (var screen in data.screenings)
                    {
                        Screening screening = new Screening()
                        {
                            ScreenNumber = screen.ScreenNumber,
                            Capacity = screen.Capacity,
                            StartsAt = DateTime.ParseExact(screen.StartsAt, "yyyy-MM-dd HH:mm:ss", culture).ToUniversalTime(),
                            MovieId = result.data.id,
                            CreatedAt = DateTime.UtcNow
                        };
                        await repository.AddScreening(screening);
                    }
                }

                //Response
                return TypedResults.Created($"http://localhost:7195/movies/{result.data.id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            try
            {
                var result = await repository.GetMovies();

                //Response
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, InputMovieDTO data, int id)
        {
            try
            {
                //Create new movie
                Movie movie = new Movie()
                {
                    Title = data.Title,
                    Rating = data.Rating,
                    Description = data.Description,
                    RuntimeMins = data.RuntimeMins,
                    CreatedAt = DateTime.UtcNow
                };
                movie.UpdatedAt = movie.CreatedAt;
                var result = await repository.UpdateMovie(id, movie);

                //Response
                return TypedResults.Created($"http://localhost:7195/movies/{result.data.id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            try
            {
                var result = await repository.RemoveMovie(id);

                //Response
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
