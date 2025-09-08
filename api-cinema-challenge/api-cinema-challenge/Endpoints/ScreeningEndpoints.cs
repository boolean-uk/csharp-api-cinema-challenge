using System.Security.Claims;
using api_cinema_challenge.DTOs.Screening;
using api_cinema_challenge.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class ScreeningEndpoints
{
    public static void ConfigureScreeningEndpoints(this WebApplication app)
    {
        var movies = app.MapGroup("movies");
        movies.MapPost("/{id}/screenings", Create).WithDescription("Create a new movie.");
        movies.MapGet("/{id}/screenings", GetAll).WithDescription("Get a list of every movie.");
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    private static async Task<IResult> Create(IRepository<Screening> screeningRepository, int id,
        ScreeningPut screeningPut, ClaimsPrincipal claimsPrincipal)
    {
        var createdAt = DateTime.UtcNow;
        var screening = new Screening
        {
            Capacity = screeningPut.Capacity,
            MovieId = id,
            ScreenNumber = screeningPut.ScreenNumber,
            StartsAt = screeningPut.StartsAt,
            CreatedAt = createdAt,
            UpdatedAt = createdAt
        };

        screeningRepository.Insert(screening);
        await screeningRepository.SaveAsync();
        
        return Results.Created("/", new ScreeningPost
        {
            Id = screening.Id,
            ScreenNumber = screening.ScreenNumber,
            Capacity = screening.Capacity,
            StartsAt = screening.StartsAt,
            CreatedAt = createdAt,
            UpdatedAt = createdAt,
        });
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    private static async Task<IResult> GetAll(IRepository<Screening> screeningRepository, int id)
    {
        var result = (await screeningRepository.GetAllAsync()).Where(screening => screening.MovieId == id);
        var postResults = result.Select(screening =>
            new ScreeningPost
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt
            }
        ).ToArray();

        if (postResults.Length == 0)
        {
            return Results.NoContent();
        }

        return Results.Ok(postResults);
    }
}