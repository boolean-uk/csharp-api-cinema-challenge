using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movies = app.MapGroup("/movies").WithTags("Movies"); ;

            movies.MapPost("/", Create);
            movies.MapGet("/", GetAll);
            movies.MapPut("/{id}", Update);
            movies.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Movie> repo, IRepository<Screening> screeningRepo, IMapper mapper, MoviePost model)
        {
            try
            {
                var newEntity = new Movie()
                {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description,
                    RuntimeMins = model.RuntimeMins,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                var createdEntity = await repo.Insert(newEntity);

                foreach (var s in model.Screenings)
                {
                    var newScreening = new Screening()
                    {
                        ScreenNumber = s.ScreenNumber,
                        Capacity = s.Capacity,
                        StartsAt = s.StartsAt,
                        MovieId = createdEntity.Id,
                    };

                    await screeningRepo.Insert(newScreening);
                }

                var getEntity = await repo.GetById(createdEntity.Id);
                var dto = mapper.Map<MovieDTO>(getEntity);
                
                var payload = new Payload<MovieDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Created($"/{getEntity.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> repo, IMapper mapper)
        {
            try
            {
                var entities = await repo.Get();
                var dtos = mapper.Map<List<MovieDTO>>(entities);
                var payload = new Payload<List<MovieDTO>>();
                payload.Status = "success";
                payload.Data = dtos;
                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Update(IRepository<Movie> repo, IMapper mapper, MoviePut model, int id)
        {
            try
            {
                var entity = await repo.GetById(id);

                if (entity == null) return TypedResults.NotFound("Entity not found");

                if (model.Title != null) entity.Title = model.Title;
                if (model.Rating != null) entity.Rating = model.Rating;
                if (model.Description != null) entity.Description = model.Description;
                if (model.RuntimeMins != null) entity.RuntimeMins = (int)model.RuntimeMins;

                entity.UpdatedAt = DateTime.UtcNow;
                var updatedEntity = await repo.Update(entity);
                var dto = mapper.Map<MovieDTO>(updatedEntity);

                var payload = new Payload<MovieDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Created($"/{updatedEntity.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Delete(IRepository<Movie> repo, IMapper mapper, int id)
        {
            try
            {
                var entity = await repo.GetById(id);
                
                if (entity == null) return TypedResults.NotFound("Entity not found");
                
                var deletedEntity = await repo.Delete(id);
                var dto = mapper.Map<MovieDTO>(deletedEntity);
                var payload = new Payload<MovieDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Ok(payload);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
