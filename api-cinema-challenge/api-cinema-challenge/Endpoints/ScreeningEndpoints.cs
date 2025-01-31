using System;
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Calls;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;

namespace api_cinema_challenge.Endpoints;

public static class ScreeningEndpoints
{
    public static void MapScreeningEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/movies/{movieId}/screenings");

        group.MapPost("/", CreateScreening);
        group.MapGet("/", GetAllScreenings);
    }

     public static async Task<IResult> CreateScreening(int movieId, IRepository<Screening> repository, ScreeningPost screeningPost, IMapper mapper)
    {
        var screening = mapper.Map<Screening>(screeningPost);
        screening.MovieId = movieId;
        var response = await repository.Create(screening);
        return TypedResults.Created("Created", new Payload<ScreeningDTO>(mapper.Map<ScreeningDTO>(response)));
    }

    public static async Task<IResult> GetAllScreenings(int movieId, IRepository<Screening> repository, IMapper mapper)
    {
        try
        {
            var screenings = await repository.GetAllFilter(s => s.MovieId == movieId);
            return TypedResults.Ok(new Payload<IEnumerable<ScreeningDTO>>(mapper.Map<IEnumerable<ScreeningDTO>>(screenings)));
        }
        catch (Exception e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }
}
