using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.EndPoints
{
    public static class MoviesApi
    {
        public static void ConfigureMoviesApi(this WebApplication app)
        {
            app.MapPost("/movies", AddMovie);
            app.MapGet("/movies", GetMovies);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> AddMovie(MoviePost model, ICinemaRepository service)
        { 
            try
            {
                return await Task.Run(() =>
                {
                    if (model == null) return Results.NotFound();

                    Movie movie = new Movie()
                    {
                        Rating = model.Rating,
                        Description = model.Description,
                        RuntimeMins = model.RuntimeMins,
                        Title = model.Title,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };

                    service.AddMovie(movie);

                    if (model.screenings.Any())
                    {
                        foreach (var screeningPost in model.screenings)
                        {
                            Screening screening = new Screening()
                            {
                                ScreenNumber = screeningPost.ScreenNumber,
                                StartsAt = screeningPost.StartsAt,
                                Capacity = screeningPost.Capacity,
                                MovieId = movie.Id,
                                CreatedAt = DateTime.UtcNow,
                                UpdatedAt = DateTime.UtcNow
                            };

                            service.AddScreening(screening);
                        }
                    }

                    Payload<Movie> result = new Payload<Movie>()
                    {
                        data = movie
                    };

                    return Results.Created($"/movies/{movie.Id}", result);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Movie>> payload = new Payload<IEnumerable<Movie>>()
                    {
                        data = service.GetAllMovies()
                    };

                    return Results.Ok(payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateMovie(int id, MoviePut model, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var movie = service.GetMovie(id);
                    movie.Rating = model.Rating;
                    movie.Title = model.Title;
                    movie.Description = model.Description;
                    movie.RuntimeMins = model.RuntimeMins;
                    movie.CreatedAt = DateTime.UtcNow;
                    movie.UpdatedAt = DateTime.UtcNow;

                    Payload<Movie> payload = new Payload<Movie>()
                    {
                        data = movie
                    };

                    if (service.UpdateMovie(movie)) return Results.Created($"/movies/{id}", payload);
                    return Results.NotFound($"No Movie with ID {id} was found!");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }                

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(int id, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var movie = service.GetMovie(id);

                    var screeningToDelete = service.GetAllScreenings().Where(s => s.MovieId == id).ToList();
                    screeningToDelete.ForEach(x => 
                    {
                       service.DeleteMovie(x.Id);
                    });

                    Payload<Movie> payload = new Payload<Movie>()
                    {
                        data = movie
                    };

                    if (service.DeleteMovie(id)) return Results.Ok(payload);
                    return Results.NotFound($"No Movie with ID {id} was found!");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}