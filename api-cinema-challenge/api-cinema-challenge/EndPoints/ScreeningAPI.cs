using api_cinema_challenge.DTOs.ScreeningDTOs;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public class ScreeningsAPI
    {
        public ScreeningsAPI(WebApplication app, IDataRepository<Movie> movies, IDataRepository<Screening> screenings)
        {
            // Create a screening for a movie
            app.MapPost("/movies/{id}/screenings", async (int id, CreateScreeningDto createScreeningDto) =>
            {
                var movie = await movies.GetById(id);
                if (movie == null)
                {
                    return Results.NotFound($"Movie with ID {id} not found.");
                }

                var newScreening = new Screening
                {
                    MovieId = id,
                    ScreenNumber = createScreeningDto.ScreenNumber,
                    Capacity = createScreeningDto.Capacity,
                    StartsAt = createScreeningDto.StartsAt
                };

                await screenings.Add(newScreening);

                var response = new SingleScreeningDto
                {
                    Status = "success",
                    Data = new ScreeningDataDto
                    {
                        Id = newScreening.Id,
                        ScreenNumber = newScreening.ScreenNumber,
                        Capacity = newScreening.Capacity,
                        StartsAt = newScreening.StartsAt,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                };

                return response.StandardizedCreated($"/movies/{id}/screenings/{newScreening.Id}");
            });

            // Get all screenings for a movie
            app.MapGet("/movies/{id}/screenings", async (int id) =>
            {
                var movie = await movies.GetById(id);
                if (movie == null)
                {
                    return Results.NotFound($"Movie with ID {id} not found.");
                }

                var allScreenings = await screenings.GetAll();
                var movieScreenings = allScreenings.Where(s => s.MovieId == id).ToList();

                var response = new AllScreeningsDto
                {
                    Status = "success",
                    Data = movieScreenings.Select(s => new ScreeningDataDto
                    {
                        Id = s.Id,
                        ScreenNumber = s.ScreenNumber,
                        Capacity = s.Capacity,
                        StartsAt = s.StartsAt,
                        CreatedAt = s.CreatedAt,
                        UpdatedAt = s.UpdatedAt
                    }).ToList()
                };

                return response.StandardizedOk();
            });
        }
    }
}