using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class MovieEndpoints
{
    public static void ConfigureMovieEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("movies");

        group.MapGet("/", GetMovies);
        group.MapPost("/", CreateMovie);
        
        group.MapGet("/{id}", GetMovie);
        group.MapPut("/{id}", UpdateMovie);
        group.MapDelete("/{id}", DeleteMovie);
    }
    
    [ProducesResponseType(typeof(BaseResponse<IEnumerable<MovieResponse>>), StatusCodes.Status200OK)]
    private static async Task<IResult> GetMovies(IRepository<Movie> repository, IMapper mapper)
    {
        var movies = await repository.GetAll();
        var response = new BaseResponse<IEnumerable<MovieResponse>>(
            Consts.SuccessStatus,
            mapper.Map<IEnumerable<MovieResponse>>(movies)
        );

        return TypedResults.Ok(response);
    }
    
    [ProducesResponseType(typeof(BaseResponse<MovieResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<>), StatusCodes.Status404NotFound)]
    private static async Task<IResult> GetMovie(IRepository<Movie> repository, IMapper mapper, int id)
    {
        var movie = await repository.Get(m => m.Id == id);
        if (movie == null) return TypedResults.NotFound(new BaseResponse<object?>(Consts.ErrorStatus, null));

        var response = new BaseResponse<MovieResponse>(
            Consts.SuccessStatus,
            mapper.Map<MovieResponse>(movie)
        );

        return TypedResults.Ok(response);
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private static async Task<IResult> CreateMovie(IRepository<Movie> repository, IMapper mapper, [FromBody] MoviePost body)
    {
        var movie = mapper.Map<Movie>(body);
        await repository.Add(movie);
        var response = new BaseResponse<MovieResponse>(
            Consts.SuccessStatus,
            mapper.Map<MovieResponse>(movie)
        );

        return TypedResults.Created($"/movies/{movie.Id}", response);
    }
    
    [ProducesResponseType(typeof(BaseResponse<MovieResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(BaseResponse<>), StatusCodes.Status404NotFound)]
    private static async Task<IResult> UpdateMovie(IRepository<Movie> repository, IMapper mapper, int id, [FromBody] MoviePut body)
    {
        var movie = await repository.Get(m => m.Id == id);
        if (movie == null) return TypedResults.NotFound(new BaseResponse<object?>(Consts.ErrorStatus, null));

        movie.Title = body.Title;
        movie.Rating = body.Rating;
        movie.Description = body.Description;
        movie.RuntimeMins = body.RuntimeMins;
        
        await repository.Update(movie);
        var response = new BaseResponse<MovieResponse>(
            Consts.SuccessStatus,
            mapper.Map<MovieResponse>(movie)
        );

        return TypedResults.Created("/movies/" + movie.Id, response);
    }
    
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
    {
        var movie = await repository.Get(m => m.Id == id);
        if (movie == null) return TypedResults.NotFound(new BaseResponse<object?>(Consts.ErrorStatus, null));

        await repository.Delete(movie);
        return TypedResults.NoContent();
    }
}