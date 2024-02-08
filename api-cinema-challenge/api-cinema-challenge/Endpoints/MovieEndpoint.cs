using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Post;
using api_cinema_challenge.Models.Types;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class MovieEndpoint
{
    public static void ConfigureMovieEndpoint(this WebApplication app)
    {
        var movieGroup = app.MapGroup("movies");

        movieGroup.MapPost("/", CreateMovie);
        movieGroup.MapGet("/", GetMovies);
        movieGroup.MapPut("/{id}", UpdateMovie);
        movieGroup.MapDelete("/{Id}", DeleteMovie);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    public static async Task<IResult> CreateMovie(IRepository<Movie> repository, PostMovie movie)
    {
        var newMovie = new Movie()
        {
            Title = movie.Title,
            Rating = movie.Rating,
            Description = movie.Description,
            RuntimeMins = movie.RuntimeMins,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        var result = await repository.Create(newMovie);
        return TypedResults.Created($"/{result.Id}", MovieDTO.ToDTO(result));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetMovies(IRepository<Movie> repository)
    {
        var result = await repository.GetAll();
        var returnList = new List<MovieDTO>();
        foreach ( var movie in result)
        {
            returnList.Add(MovieDTO.ToDTO(movie));
        }
        return TypedResults.Ok(returnList);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, PostMovie movie)
    {
        var updatedMovie = await repository.GetById(id);
        if (updatedMovie == null)
        {
            return TypedResults.NotFound("Unable to find the movie!");
        }
        updatedMovie.Title = movie.Title;
        updatedMovie.Rating = movie.Rating;
        updatedMovie.Description = movie.Description;
        updatedMovie.RuntimeMins = movie.RuntimeMins;
        updatedMovie.UpdatedAt = DateTime.UtcNow;
        var result = await repository.Update(updatedMovie);
        if (result == null)
        {
            return TypedResults.BadRequest("Failed to update the movie!");
        }
        return TypedResults.Ok(MovieDTO.ToDTO(result));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
    {
        var deletedMovie = await repository.Delete(id);
        if (deletedMovie == null)
        {
            return TypedResults.NotFound("Unable to find the movie!");
        }
        return TypedResults.Ok(MovieDTO.ToDTO(deletedMovie));
    }
}
