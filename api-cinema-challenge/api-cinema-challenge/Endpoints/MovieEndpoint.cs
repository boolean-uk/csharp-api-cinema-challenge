using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class MovieEndpoint
{
    public static void ConfigureMovieEndpoint(this IEndpointRouteBuilder routes)
    {
        var group = routes
            .MapGroup("/movies")
            .WithTags("Movie")
            .WithSummary("Movies API")
            .WithDescription("This API allows you to manage Movies at the cinema.")
            .WithOpenApi();

        group.MapGet("/", GetMovies)
            .WithName("GetMovies")
            .WithSummary("Get all movies.")
            .WithDescription("Retrieves all movies from cinema data base.")
            .Produces<IEnumerable<MovieGetDto>>(StatusCodes.Status200OK);

        group.MapPost("/", PostMovie)
            .WithName("PostMovie")
            .WithSummary("Create a new movie.")
            .WithDescription("Creates a new movie in the cinema data base.")
            .Accepts<MoviePostDto>("application/json")
            .Produces<MoviePostDto>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest);

        group.MapPut("/{id:int}", UpdateMovie)
            .WithName("UpdateMovie")
            .WithSummary("Update an existing movie.")
            .WithDescription("Updates an existing movie in the cinema data base.")
            .Accepts<MovieUpdateDto>("application/json")
            .Produces<MovieUpdateDto>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest);
        
        group.MapDelete("/{id:int}", DeleteMovie)
            .WithName("DeleteMovie")
            .WithSummary("Delete an existing movie.")
            .WithDescription("Deletes an existing movie from the cinema data base.")
            .Produces<MovieGetDto>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest);
        
        group.MapPost("/{id:int}/screenings/", CreateScreening)
            .WithName("CreateScreening")
            .WithTags("Screening")
            .WithSummary("Create a new screening for an existing movie.")
            .Produces<ScreeningGetDto>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest);
        
        group.MapGet("/{id:int}/screenings/", GetScreenings)
            .WithName("GetScreenings")
            .WithTags("Screening")
            .WithSummary("Get all screenings for an existing movie.")
            .Produces<IEnumerable<ScreeningGetDto>>(StatusCodes.Status200OK);
        
    }
    
    private static async Task<IResult> GetScreenings(IMovieRepository repository, int id)
    {
        return TypedResults.Ok(await repository.GetScreenings(id));
    }
    
    private static async Task<IResult> CreateScreening(IMovieRepository repository, int id, ScreeningPostDto screening)
    {
        try
        {
            var createdScreening = await repository.CreateScreening(id, screening);
            return TypedResults.Created($"/movies/{id}/screenings/", createdScreening);
        }
        catch (ArgumentException e)
        {
            return TypedResults.Problem(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.Problem("An unknown error occurred while creating the screening.");
        }
    }

    private static async Task<IResult> GetMovies(IMovieRepository repository)
    {
        return TypedResults.Ok(await repository.GetMovies());
    }

    private static async Task<IResult> PostMovie(IMovieRepository repository, MoviePostDto movie)
    {
        try
        {
            var createdMovie = await repository.PostMovie(movie);
            return TypedResults.Created("/movies/", createdMovie);
        }
        catch (ArgumentException e)
        {
            return TypedResults.Problem(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.Problem("An unknown error occurred while creating the movie.");
        }
    }

    private static async Task<IResult> UpdateMovie(IMovieRepository repository, MovieUpdateDto movie, int id)
    {
        try
        {
            var createdMovie = await repository.UpdateMovie(id, movie);
            return TypedResults.Created($"/movies/", createdMovie);
        }
        catch (ArgumentException e)
        {
            return TypedResults.Problem(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.Problem("An unknown error occurred while creating the movie.");
        }
    }
    
    private static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
    {
        try
        {
            var deletedMovie = await repository.DeleteMovie(id);
            return TypedResults.Ok(deletedMovie);
        }
        catch (ArgumentException e)
        {
            return TypedResults.Problem(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.Problem("An unknown error occurred while deleting the movie.");
        }
    }
}