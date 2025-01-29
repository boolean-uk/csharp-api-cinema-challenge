using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            app.MapGet("/", GetScreeningsByMovieId);
            app.MapGet("/movies/{id}/screenings", GetScreeningsByMovieId);
            app.MapPost("/movies/{id}/screenings", CreateScreening);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetScreeningsByMovieId(IRepository<Screening> rep, IMapper mapper, int? id)
        {
            try
            {
                var screenings = await rep.GetAll(id, null);

                var response = mapper.Map<ResponseDTO<ScreeningDTO>>(screenings);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> rep, IMapper mapper, int id, ScreeningPOST model)
        {
            try
            {
                var screening = mapper.Map<Screening>(model);
                screening.MovieId = id;

                await rep.Create(screening);

                var response = mapper.Map<ResponseSingleDTO<ScreeningDTO>>(screening);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }
    }
}
