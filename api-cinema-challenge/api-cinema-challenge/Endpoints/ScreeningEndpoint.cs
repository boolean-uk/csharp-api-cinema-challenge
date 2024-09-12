using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class ScreeningEndpoint
{
    public static void ConfigureScreeningsApi(this WebApplication app)
    {
        var screenings = app.MapGroup("screenings");

        screenings.MapPost("/", AddScreening);
        screenings.MapGet("/", GetScreenings);
        screenings.MapGet("/{id}", GetScreeningById);
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> AddScreening(IRepository<Screening> movieRepo, IRepository<Screening> repo, ScreeningPayload model)
    {
        var movie = movieRepo.GetById(model.MovieId);
        if (movie is null) return TypedResults.NotFound($"Movie with id {model.MovieId} not found");
        var timeNow = DateTime.UtcNow;
        var s = new Screening()
        {
            ScreenNumber = model.ScreenNumber,
            Capacity = model.Capacity,
            MovieId = model.MovieId,
            StartDate = model.startsAt,
            CreatedAt = timeNow,
            UpdatedAt = timeNow
        };
        var result = await repo.Add(s);
        return TypedResults.Created($"/customers/{s.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private async static Task<IResult> GetScreenings(IRepository<Screening> repo)
    {
        var result = await repo.GetAll();
        var resultDto = result.Select(s => new ScreeningDTO()
        {
            Id = s.Id,
            ScreenNumber = s.ScreenNumber,
            Capacity = s.Capacity,
            StartsAt = s.StartDate,
            CreatedAt = s.CreatedAt,
            UpdatedAt = s.UpdatedAt
        });
        return TypedResults.Ok(new ReturnValue("success", resultDto));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> GetScreeningById(IRepository<Screening> repo, int id)
    {
        var s = await repo.GetById(id);
        return s is null ? TypedResults.NotFound($"Screening with id {id} not found") : TypedResults.Ok(new ReturnValue("success", s));
    }
}