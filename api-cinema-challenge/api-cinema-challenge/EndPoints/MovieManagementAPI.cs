using api_cinema_challenge.DTOs.ScreeningDTOs;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public class MovieManagementAPI
    {
        public MovieManagementAPI(WebApplication app, IDataRepository<Movie> movies, IDataRepository<Screening> screenings)
        {
            // Creating movies with its screenings
            app.MapPost("/movies", async (CreateMovieDto movieRequest) =>
            {
                var movie = new Movie
                {
                    Title = movieRequest.Title,
                    Rating = movieRequest.Rating,
                    Description = movieRequest.Description,
                    RuntimeMins = movieRequest.RuntimeMins,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await movies.Add(movie);

                if (movieRequest.Screenings != null)
                {
                    foreach (var screeningDto in movieRequest.Screenings)
                    {
                        var screening = new Screening
                        {
                            ScreenNumber = screeningDto.ScreenNumber,
                            Capacity = screeningDto.Capacity,
                            StartsAt = screeningDto.StartsAt,
                            MovieId = movie.Id
                        };
                        await screenings.Add(screening);
                    }
                }

                var response = new SingleMovieDto
                {
                    Status = "success",
                    Data = new MovieDataDto
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Rating = movie.Rating,
                        Description = movie.Description,
                        RuntimeMins = movie.RuntimeMins,
                        CreatedAt = movie.CreatedAt,
                        UpdatedAt = movie.UpdatedAt
                    }
                };

                return response.StandardizedCreated($"/movies/{movie.Id}");
            });

            // Delete a movie and its screenings (cascade delete)
            app.MapDelete("/movies/{id}", async (int id) =>
            {
                var movie = await movies.GetById(id);
                if (movie == null)
                {
                    return Results.NotFound($"Movie with ID {id} not found.");
                }

                // Delete associated screenings
                var movieScreenings = (await screenings.GetAll()).Where(s => s.MovieId == id).ToList();
                foreach (var screening in movieScreenings)
                {
                    await screenings.Delete(screening.Id);
                }

                await movies.Delete(id);

                return Results.Ok($"Movie with ID {id} and its screenings have been deleted.");
            });
        }
    }
}