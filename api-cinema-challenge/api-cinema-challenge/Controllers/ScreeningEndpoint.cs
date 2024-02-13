using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        //TODO:  add additional endpoints in here according to the requirements in the README.md 
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/screenings", GetScreenings);
            cinemaGroup.MapGet("/screening/{id}", GetScreeningById);
            cinemaGroup.MapPost("/screening", CreateScreening);
            cinemaGroup.MapPut("/screening/{id}", UpdateScreening);
            cinemaGroup.MapDelete("/screening/{id}", DeleteScreening);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, IService service)
        {
            var data = await repository.Get();
            var output = await service.MultipleToDto<Screening, ScreeningDto>(data);
            var outputPayload = new Payload<IEnumerable<ScreeningDto>> { data = output };
            return TypedResults.Ok(outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningById(IRepository<Screening> repository, IService service, int id)
        {
            var data = await repository.GetById(id);
            if (data == null) { return TypedResults.NotFound("Screening not found"); }
            var output = await service.SingleToDto<Screening, ScreeningDto>(data);
            var outputPayload = new Payload<ScreeningDto> { data = output };
            return TypedResults.Ok(outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, IService service, ScreeningPost input)
        {
            if (repository.Get().Result.Any(x => x.StartTime == input.StartTime && x.HallId == input.HallId))
            {
                return TypedResults.BadRequest("This hall already has a screening at this time");
            }
            Screening screening = new Screening()
            {
                StartTime = input.StartTime,
                HallId = input.HallId,
                MovieId = input.MovieId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var data = await repository.Create(screening, x => x.Hall, x=> x.Movie);
            var output = await service.SingleToDto<Screening, ScreeningDto>(data);
            var outputPayload = new Payload<ScreeningDto> { data = output };
            return TypedResults.Created($"/{data.Id}", outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateScreening(IRepository<Screening> repository, IService service, int id, ScreeningPut input)
        {
            if (repository.Get().Result.Any(x => x.StartTime == input.StartTime && x.HallId == input.HallId))
            {
                return TypedResults.BadRequest("This hall already has a screening at this time");
            }
            Screening screening = await repository.GetById(id);
            if (screening == null) { return TypedResults.NotFound("Screening not found"); }
            screening.HallId = input.HallId;
            screening.MovieId = input.MovieId;
            screening.UpdatedAt = DateTime.UtcNow;
            var data = await repository.Update(screening);
            var output = await service.SingleToDto<Screening, ScreeningDto>(data);
            var outputPayload = new Payload<ScreeningDto> { data = output };
            return TypedResults.Ok(outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteScreening(IRepository<Screening> repository, IService service, int id)
        {
            if (await repository.GetById(id) == null) { return TypedResults.NotFound("Screening not found"); }
            var data = await repository.Delete(id);
            var output = await service.SingleToDto<Screening, ScreeningDto>(data);
            var outputPayload = new Payload<ScreeningDto> { data = output };
            return TypedResults.Ok(outputPayload);
        }
    }
}