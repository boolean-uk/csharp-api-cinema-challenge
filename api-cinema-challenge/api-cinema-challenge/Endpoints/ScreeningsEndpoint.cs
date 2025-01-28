
using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace workshop.wwwapi.Endpoints
{
    public static class ScreeningsEndpoint
    {
        public static void ConfigureScreeningsEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("/movies/{id}/screenings");
            screenings.MapPost("/", CreateAScreening);
            screenings.MapGet("/", GetAllScreenings);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAScreening(HttpContext context, IRepository<Screenings> repo, int screeningId, Create_Screening dto)
        {
            var screening = Create_Screening.create(dto, screeningId);

            var entity = await repo.CreateEntry(screening);

            return TypedResults.Created(context.Get_endpointUrl(entity.Id), Get_Screening.toPayload(entity));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllScreenings( IRepository<Screenings> repo, int id)
        {
            var entries = await repo.GetEntries( x => x.Where( x => x.MovieId == id));
            return TypedResults.Ok(Get_Screening.toPayload(entries));
        }
        



    }
}
