using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapPost("/movies", CreateAMovie);
            app.MapGet("/movies", GetAllMovies);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAMovie(MoviePost movie, IMovieRepo service, IScreeningRepo screen)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (movie == null) return Results.NotFound();
                    Movie newMovie = new Movie();
                    newMovie.title = movie.title;
                    newMovie.rating = movie.rating;
                    newMovie.description = movie.description;
                    newMovie.runtimeMins = movie.runtimeMins;
                    newMovie.createdAt = DateTime.UtcNow;
                    newMovie.updatedAt = DateTime.UtcNow;
                    
                    service.AddMovie(newMovie);

                    if (movie.screenings.Any())
                    {
                        foreach(var screeningPost in movie.screenings)
                        {
                            Screening screening = new Screening()
                            {
                                screenNumber = screeningPost.screenNumber,
                                startsAt = screeningPost.startsAt,
                                capacity = screeningPost.capacity,
                                MovieId = newMovie.Id,
                                createdAt = DateTime.UtcNow,
                                updatedAt = DateTime.UtcNow,
                            };
                            screen.AddScreening(screening);
                        }
                    }

                    Payload<Movie> payload = new Payload<Movie>()
                    {
                        data = newMovie
                    };

                    return Results.Created($"https://localhost:7195/customer/{newMovie.Id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllMovies(IMovieRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Movie>> payload = new Payload<IEnumerable<Movie>>()
                    {
                        data = service.GetAllMovies().ToList()
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
        private static async Task<IResult> UpdateMovie(MoviePost movie, IMovieRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (movie == null) return Results.NotFound();
                    Movie newMovie = new Movie();
                    newMovie.title = movie.title;
                    newMovie.rating = movie.rating;
                    newMovie.description = movie.description;
                    newMovie.runtimeMins = movie.runtimeMins;
                    newMovie.createdAt = DateTime.UtcNow;
                    newMovie.updatedAt = DateTime.UtcNow;
                    service.UpdateMovie(newMovie);
                    Payload<Movie> payload = new Payload<Movie>()
                    {
                        data = newMovie
                    };

                    return Results.Created($"https://localhost:7195/customer/{newMovie.Id}", payload);
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteMovie(int id, IMovieRepo service, IScreeningRepo screen)
        {
            using (var db = new CinemaContext())
                try
                {
                    var target = db.Movies.FirstOrDefault(c => c.Id == id);
                    if (target == null) return Results.NotFound();
                    Movie newMovie = new Movie();
                    newMovie.title = target.title;
                    newMovie.rating = target.rating;
                    newMovie.description = target.description;
                    newMovie.runtimeMins = target.runtimeMins;
                    newMovie.createdAt = DateTime.UtcNow;
                    newMovie.updatedAt = DateTime.UtcNow;

                    // here I would add target.screenings and then
                    // check if screening.MovieId == id to Remove
                    // any screenings for this movie but I only
                    // have screenings in the MoviePost instead of Movie

                    Payload<Movie> payload = new Payload<Movie>()
                    {
                        data = newMovie
                    };
                    if (service.DeleteMovie(id))
                    {


                        return Results.Created($"https://localhost:7195/customer/{newMovie.Id}", payload);
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
        }
    }
}
