using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class screeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("screenings");

            group.MapGet("", GetAll);
            group.MapGet("{id}", Get);
            group.MapPost("", Create);
            group.MapPut("{id}", Update);
            group.MapDelete("{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAll(IRepository<Screening> repository)
        {
            IEnumerable<Screening> screenings = await repository.Get();

            IEnumerable<OutputScreening> outputScreenings = ScreeningDtoManager.Convert(screenings);
            return TypedResults.Ok(outputScreenings);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Get(int id, IRepository<Screening> repository)
        {
            Screening? screening = await repository.Get(id);
            if (screening == null)
                return Results.NotFound();

            OutputScreening outputScreening = ScreeningDtoManager.Convert(screening);
            return TypedResults.Ok(outputScreening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> Create(InputScreening screening, IRepository<Screening> repository)
        {
            Screening newScreening = ScreeningDtoManager.Convert(screening); 

            Screening result = await repository.Create(newScreening);

            OutputScreening outputScreening = ScreeningDtoManager.Convert(result);
            return TypedResults.Created("url", outputScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Update(int id, InputScreening screening, IRepository<Screening> repository)
        {
            Screening screeningToUpdate = await repository.Get(id);

            screeningToUpdate.UpdatedAt = DateTime.UtcNow;
            screeningToUpdate.StartsAt = screening.StartsAt;
            screeningToUpdate.ScreenNumber = screening.ScreenNumber;
            screeningToUpdate.Capacity = screening.Capacity;

            Screening result = await repository.Update(screeningToUpdate);

            OutputScreening outputScreening = ScreeningDtoManager.Convert(result);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Delete(int id, IRepository<Screening> repository)
        {
            Screening result = await repository.Delete(id);

            OutputScreening outputScreening = ScreeningDtoManager.Convert(result);
            return TypedResults.Ok(outputScreening);
        }
    }
}
