using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class ScreeningEndpoints
{
    public static void ConfigureScreeningEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("movies/{id}/screenings");

        group.MapGet("/", GetScreenings);
        group.MapPost("/", CreateScreening);
    }
    
    [ProducesResponseType(typeof(BaseResponse<IEnumerable<ScreeningResponse>>), StatusCodes.Status200OK)]
    private static async Task<IResult> GetScreenings(IRepository<Screening> repository, IMapper mapper, int id)
    {
        var screenings = await repository.GetAll(s => s.MovieId == id);
        var response = new BaseResponse<IEnumerable<ScreeningResponse>>(
            Consts.SuccessStatus,
            mapper.Map<IEnumerable<ScreeningResponse>>(screenings)
        );

        return TypedResults.Ok(response);
    }
    
    [ProducesResponseType(typeof(BaseResponse<ScreeningResponse>), StatusCodes.Status201Created)]
    private static async Task<IResult> CreateScreening(IRepository<Screening> repository, IMapper mapper, int id, [FromBody] ScreeningPost body)
    {
        var screening = mapper.Map<Screening>(body);
        screening.MovieId = id;
        await repository.Add(screening);
        var response = new BaseResponse<ScreeningResponse>(
            Consts.SuccessStatus,
            mapper.Map<ScreeningResponse>(screening)
        );

        return TypedResults.Created($"/movies/{id}/screenings", response);
    }
}