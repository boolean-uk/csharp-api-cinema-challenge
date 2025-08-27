using api_cinema_challenge.DTOs.Movies;
using api_cinema_challenge.DTOs.Screenings;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screening = app.MapGroup("/movies");

            screening.MapPost("/{id}/screenings", Create);
            screening.MapGet("/{id}/screenings", GetAll);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Screening> screeningRepository, int id)
        {
            List<Screening> results = (List<Screening>)await screeningRepository.Get();
            List<object> response = new List<object>();
            foreach (var item in results)
            {
                if (item.movieId == id)
                {
                    response.Add(item);
                }
            }

            return TypedResults.Ok(response);
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> Create(int id, IRepository<Screening> screeningRepository, ScreeningPostPut model)
        {
            Screening screening = new Screening()
            {
                movieId = id,
                ScreenNumber = model.ScreenNumber,
                Capacity = model.Capacity,
                StartsAt = model.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var entity = await screeningRepository.Insert(screening);


            return TypedResults.Created($"", entity);
        }


    }
}
