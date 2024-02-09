using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Post;
using api_cinema_challenge.Models.Types;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class ScreeningEndpoint
{
    public static void ConfigureScreeningEndpoint(this WebApplication app)
    {
        var screeningGroup = app.MapGroup("screenings");

        screeningGroup.MapPost("/{id}", CreateScreening);
        screeningGroup.MapGet("/{id}", GetScreenings);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    public static async Task<IResult> CreateScreening(IRepository<Screening> repository, IRepository<Movie> movieRepository, int id, PostScreening screening)
    {
        var movie = await movieRepository.GetById(id);
        if (movie == null)
        {
            return TypedResults.NotFound(new Payload<string>() { Status = "fail", Data = "Movie not found!" });
        }
        var newScreening = new Screening()
        {
            MovieId = id,
            Movie = movie,
            ScreenNumber = screening.screenNumber,
            Capacity = screening.capacity,
            StartsAt = screening.StartsAt,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        var result = await repository.Create(newScreening);
        return TypedResults.Created($"/{result.Id}", new Payload<ScreeningDTO>() { Data = ScreeningDTO.ToDTO(result) });
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetScreenings(IRepository<Screening> repository, int id)
    {
        var allScreening = await repository.GetAll();
        var result = allScreening.Where(x => x.MovieId == id).ToList();
        var returnList = new List<ScreeningDTO>();
        foreach (var screening in result)
        {
            returnList.Add(ScreeningDTO.ToDTO(screening));
        }
        return TypedResults.Ok(new Payload<List<ScreeningDTO>>() { Data = returnList });
    }
}
