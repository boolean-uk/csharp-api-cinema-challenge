using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {

        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("screenings");

            group.MapGet("/", GetScreenings);
            group.MapPost("/", CreateScreening);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Screening> screenings = await repository.GetAll();

                if (!screenings.Any()) return TypedResults.NotFound();

                return TypedResults.Ok(mapper.Map<IEnumerable<ScreeningDTO>>(screenings));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, IMapper mapper, IValidator<CreateScreening> validator, CreateScreening entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(validationResult.Errors);
                }

                Screening newScreening = new Screening
                {
                    ScreenNumber = entity.ScreenNumber,
                    Capacity = entity.Capacity,
                    StartsAt = entity.StartsAt,
                    MovieId = entity.MovieId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                


                Screening screening = await repository.Add(newScreening);

                return TypedResults.Created($"https://localhost:7235/screenings/", mapper.Map<ScreeningDTO>(screening));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

       

    }
}
