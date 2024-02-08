using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Services;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Models;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
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
            var payload = new Payload<IEnumerable<OutputScreening>>(outputScreenings);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Get(int id, IRepository<Screening> repository)
        {
            Screening? screening = await repository.Get(id);
            if (screening == null)
                return TypedResults.NotFound(new Payload<Screening>(screening));

            OutputScreening outputScreening = ScreeningDtoManager.Convert(screening);
            var payload = new Payload<OutputScreening>(outputScreening);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> Create(InputScreening screening, IRepository<Screening> repository)
        {
            Screening newScreening = ScreeningDtoManager.Convert(screening);

            Screening result = await repository.Create(newScreening);

            OutputScreening outputScreening = ScreeningDtoManager.Convert(result);
            var payload = new Payload<OutputScreening>(outputScreening);
            return TypedResults.Created("url", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Update(int id, InputScreening screening, IRepository<Screening> repository)
        {
            Screening? screeningToUpdate = await repository.Get(id);
            if (screeningToUpdate == null)
                return TypedResults.NotFound(new Payload<Screening>(screeningToUpdate));

            screeningToUpdate.UpdatedAt = DateTime.UtcNow;
            screeningToUpdate.StartsAt = screening.StartsAt;
            screeningToUpdate.ScreenNumber = screening.ScreenNumber;
            screeningToUpdate.Capacity = screening.Capacity;

            Screening result = await repository.Update(screeningToUpdate);

            OutputScreening outputScreening = ScreeningDtoManager.Convert(result);
            var payload = new Payload<OutputScreening>(outputScreening);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Delete(int id, IRepository<Screening> repository)
        {
            Screening? screening = await repository.Delete(id);
            if (screening == null)
                return TypedResults.NotFound(new Payload<Screening>(screening));

            OutputScreening outputScreening = ScreeningDtoManager.Convert(screening);
            var payload = new Payload<OutputScreening>(outputScreening);
            return TypedResults.Ok(payload);
        }
    }
}
