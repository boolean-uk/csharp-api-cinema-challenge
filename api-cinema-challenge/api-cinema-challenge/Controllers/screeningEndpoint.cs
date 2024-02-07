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
        private static async Task<IEnumerable<Screening>> GetAll(IRepository<Screening> repository)
        {
            return await repository.Get();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<Screening> Get(int id, IRepository<Screening> repository)
        {
            return await repository.Get(id);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<Screening> Create(InputScreening screening, IRepository<Screening> repository)
        {
            Screening newScreening = ScreeningDtoManager.Convert(screening); 
            return await repository.Create(newScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<Screening> Update(int id, InputScreening screening, IRepository<Screening> repository)
        {
            Screening screeningToUpdate = await repository.Get(id);

            screeningToUpdate.UpdatedAt = DateTime.UtcNow;
            screeningToUpdate.StartsAt = screening.StartsAt;
            screeningToUpdate.ScreenNumber = screening.ScreenNumber;
            screeningToUpdate.Capacity = screening.Capacity;

            return await repository.Update(screeningToUpdate);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<Screening> Delete(int id, IRepository<Screening> repository)
        {
            return await repository.Delete(id);
        }
    }
}
