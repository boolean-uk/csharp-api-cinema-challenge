using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class MovieEndpoints
{
    public static void ConfigureMovieEndpoints(this WebApplication app)
    {
        var movies = app.MapGroup("movies");
        movies.MapPost("/", Create).WithDescription("Create a new movie.");
        movies.MapGet("/", GetAll).WithDescription("Get a list of every movie.");
        movies.MapPatch("/{id:int}", Update).WithDescription("Update an existing movie. For ease of implementation, all fields are required from the client.");
        movies.MapDelete("/{id:int}", Delete).WithDescription("Delete an existing movie. When deleting data, it's useful to send the deleted record back to the client so they can re-create it if deletion was a mistake.");
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    private static async Task<IResult> Create(IRepository<Movie> movieRepository, MoviePut moviePut)
    {
        var createdAt = DateTime.UtcNow;
        var movie = new Movie
        {
            Title = moviePut.Title,
            Description = moviePut.Description,
            Rating = moviePut.Rating,
            RuntimeMins = moviePut.RuntimeMins,
            CreatedAt = createdAt,
            UpdatedAt = createdAt,
        };

        movieRepository.Insert(movie);
        await movieRepository.SaveAsync();
        
        return Results.Created("/", new MoviePost
        {
            Id = movie.Id,
            Title = movie.Title,
            Rating = movie.Rating,
            Description = movie.Description,
            RuntimeMins = movie.RuntimeMins,
            CreatedAt = createdAt,
            UpdatedAt = createdAt,
        });
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    private static async Task<IResult> GetAll(IRepository<Movie> movieRepository)
    {
        var result = await movieRepository.GetAllAsync();
        var postResults = result.Select(m =>
            new MoviePost
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                Rating = m.Rating,
                RuntimeMins = m.RuntimeMins,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt
            }
        ).ToArray();

        if (postResults.Length == 0)
        {
            return Results.NoContent();
        }
        
        return Results.Ok(postResults);
    }
    
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> Update(IRepository<Movie> movieRepository, int id, MoviePut moviePut)
    {
        var movie = await movieRepository.GetByIdAsync(id);
        if (movie == null)
        {
            return Results.NotFound("Movie not found");
        }
        
        movie.Title = moviePut.Title;
        movie.Description = moviePut.Description;
        movie.Rating = moviePut.Rating;
        movie.RuntimeMins = moviePut.RuntimeMins;
        
        movieRepository.Update(movie);
        await movieRepository.SaveAsync();
        
        return Results.Ok(new MoviePost
        {
            Id = movie.Id,
            Title = movie.Title,
            Description = movie.Description,
            Rating = movie.Rating,
            RuntimeMins = movie.RuntimeMins,
            CreatedAt = movie.CreatedAt,
            UpdatedAt = movie.UpdatedAt
        });
    }
    
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> Delete(IRepository<Movie> movieRepository, int id)
    {
        var movie = await movieRepository.GetByIdAsync(id);
        if (movie == null)
        {
            return Results.NotFound("Movie not found");
        }

        movieRepository.Delete(movie);
        await movieRepository.SaveAsync();
        
        return Results.Ok(new MoviePost
        {
            Id = movie.Id,
            Title = movie.Title,
            Description = movie.Description,
            Rating = movie.Rating,
            RuntimeMins = movie.RuntimeMins,
            CreatedAt = movie.CreatedAt,
            UpdatedAt = movie.UpdatedAt
        });
    }
}