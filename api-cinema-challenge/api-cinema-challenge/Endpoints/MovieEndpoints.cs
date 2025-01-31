using System;
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Calls;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;

namespace api_cinema_challenge.Endpoints;

public static class MovieEndpoints
{
    public static void MapMovieEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/movies");

        group.MapPost("/", CreateMovie);
        group.MapGet("/", GetAllMovies);
        group.MapPut("/{id}", UpdateMovie);
        group.MapDelete("/{id}", DeleteMovie);
    }

    public static async Task<IResult> CreateMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, MoviePost moviePost, IMapper mapper)
    {
        var movie = mapper.Map<Movie>(moviePost);
        var response = await movieRepository.Create(movie);

        if (moviePost.Screenings != null)
        {
            foreach (var screeningPost in moviePost.Screenings)
            {
                var screening = mapper.Map<Screening>(screeningPost);
                screening.MovieId = response.Id;
                await screeningRepository.Create(screening);
            }
        }

        return TypedResults.Created("Created", new Payload<MovieDTO>(mapper.Map<MovieDTO>(response)));
    }

    public static async Task<IResult> GetAllMovies(IRepository<Movie> repository, IMapper mapper)
    {
        try
        {
            var movies = await repository.GetAll();
            return TypedResults.Ok(new Payload<IEnumerable<MovieDTO>>(mapper.Map<IEnumerable<MovieDTO>>(movies)));
        }
        catch (Exception e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }

    public static async Task<IResult> UpdateMovie(int id, IRepository<Movie> repository, MoviePut moviePut, IMapper mapper)
    {
        var movie = await repository.GetById(id);
        if (movie == null)
        {
            return TypedResults.NotFound($"No entity with id {id} found");
        }

        mapper.Map(moviePut, movie); // Map moviePut to the existing movie entity
        await repository.Update(movie);
        return TypedResults.Ok(new Payload<MovieDTO>(mapper.Map<MovieDTO>(movie)));
    }

    public static async Task<IResult> DeleteMovie(int id, IRepository<Movie> repository, IMapper mapper)
    {
        try
        {
            var movie = await repository.Delete(id);
            return TypedResults.Ok(new Payload<MovieDTO>(mapper.Map<MovieDTO>(movie)));
        }
        catch (Exception e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }

   
}