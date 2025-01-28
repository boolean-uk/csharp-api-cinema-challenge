using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screenings = app.MapGroup("/movies/{id}/screenings").WithTags("Screenings"); ;

            screenings.MapPost("/", Create);
            screenings.MapGet("/", GetAll); 
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Screening> repo, IMapper mapper, ScreeningPost model, int id)
        {
            try
            {
                var newEntity = new Screening()
                {
                    ScreenNumber = model.ScreenNumber,
                    Capacity = model.Capacity,
                    StartsAt = model.StartsAt,
                    MovieId = id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                var createdEntity = await repo.Insert(newEntity);
                var dto = mapper.Map<ScreeningDTO>(createdEntity);

                var payload = new Payload<ScreeningDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Created($"/{createdEntity.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        /*
         * Get all screenings for a movie 
         */
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> repo, IMapper mapper, int id)
        {
            try
            {
                var entities = await repo.GetByIdWithNestedIncludes(e => e.Id == id,
                    query => query
                    .Include(e => e.Screenings)
                );
                var dtos = mapper.Map<List<ScreeningDTO>>(entities.Screenings);
                var payload = new Payload<List<ScreeningDTO>>();
                payload.Status = "success";
                payload.Data = dtos;
                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
