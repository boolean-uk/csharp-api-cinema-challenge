using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class MovieEndpoint
{
    public static void ConfigureMoviesApi(this WebApplication app)
    {
        var movies = app.MapGroup("movies");

        movies.MapPost("/", AddMovie);
        movies.MapGet("/", GetMovies);
        movies.MapPut("/{id}", UpdateMovie);
        movies.MapDelete("/{id}", DeleteMovie);
        movies.MapGet("/{id}", GetMovieById);
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> AddMovie(IRepository<Movie> repo, MoviePayload model)
    {
        var timeNow = DateTime.UtcNow;
        var m = new Movie()
        {
            Title = model.Title,
            Rating = model.Rating,
            Description = model.Description,
            DurationMinutes = model.Duration,
            CreatedAt = timeNow,
            UpdatedAt = timeNow
        };
        var result = await repo.Add(m);
        return TypedResults.Created($"/movies/{m.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private async static Task<IResult> GetMovies(IRepository<Movie> repo)
    {
        var result = await repo.GetAll();
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> UpdateMovie(IRepository<Movie> repo, int id, MoviePayload model)
    {
        var m = await repo.GetById(id);
        if (!string.IsNullOrEmpty(model.Title)) m.Title = model.Title;
        if (!string.IsNullOrEmpty(model.Rating)) m.Rating = model.Rating;
        if (!string.IsNullOrEmpty(model.Description)) m.Description = model.Description;
        if (model.Duration > 0) m.DurationMinutes = model.Duration;
        m.UpdatedAt = DateTime.UtcNow;
        var result = await repo.Update(m);
        return TypedResults.Created($"/customers/{m.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
    {
        var m = await repo.GetById(id);
        if (m is null) return TypedResults.NotFound($"Movie with id {id} not found");
        var result = await repo.Delete(m);
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> GetMovieById(IRepository<Movie> repo, int id)
    {
        var m = await repo.GetById(id);
        return m is null ? TypedResults.NotFound($"Movie with id {id} not found") : TypedResults.Ok(new ReturnValue("success", m));
    }
}