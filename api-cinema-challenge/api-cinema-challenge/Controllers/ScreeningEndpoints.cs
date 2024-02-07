using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screening");

            screeningGroup.MapPost("/", CreateScreening);
            screeningGroup.MapGet("/", GetAllScreenings);


        }


        public static async Task<IResult> CreateScreening([FromBody] ScreeningPayload payload, [FromServices] IRepository repository, int movieId)
        {
            Screening? screening = await repository.CreateScreening(payload.ScreenNumber, payload.Capacity, payload.StartAt, movieId);
            if (screening == null)
            {
                return Results.BadRequest("Failed to create a screening.");
            }

            repository.SaveChanges();

            ScreeningDto screeningDto = new ScreeningDto(screening);

            return TypedResults.Created($"/Movie {screening.Id}", screeningDto);
        }


        public static async Task<IResult> GetAllScreenings(IRepository repository)
        {
            var screenings = await repository.GetAllScreenings();

            List<Object> result = new List<Object>();
            foreach (Screening screening in screenings)
            {
                var addScreening = new ScreeningDto(screening);
                result.Add(addScreening);
            }

            return TypedResults.Ok(result);
        }
      
    }
}
