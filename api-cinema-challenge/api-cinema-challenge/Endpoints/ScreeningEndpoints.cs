using api_cinema_challenge.DataTransfer.Requests;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("/screenings");

            screenings.MapPost("/", Create);
            screenings.MapGet("/", GetAll);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Screening> repository, ScreenPostRequest screening, int movieId)
        {
            var newScreening = new Screening()
            {
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                startsAt = screening.StartsAt,
                MovieId = movieId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            await repository.Create(newScreening);
            return TypedResults.Created($"/{newScreening.Id}", newScreening);
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Screening> repository)
        {
            var entities = await repository.GetAll();
            List<Object> results = new List<Object>();

            foreach (var entity in entities)
            {
                results.Add(new
                {
                    ScreenNumber = entity.ScreenNumber,
                    Capacity = entity.Capacity,
                    StartsAt = entity.startsAt,
                    MovieId = entity.MovieId
                });
            }

            return TypedResults.Ok(results);
        }
    }
}
