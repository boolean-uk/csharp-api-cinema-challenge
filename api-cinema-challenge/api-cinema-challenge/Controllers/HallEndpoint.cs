using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Controllers
{
    public static class HallEndpoint
    {
        //TODO:  add additional endpoints in here according to the requirements in the README.md 
        public static void ConfigureHallEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/halls", GetHalls);
            cinemaGroup.MapGet("/hall/{id}", GetHallById);
            cinemaGroup.MapPost("/hall", CreateHall);
            cinemaGroup.MapPut("/hall/{id}", UpdateHall);
            cinemaGroup.MapDelete("/hall/{id}", DeleteHall);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetHalls(IRepository<Hall> repository, IService service)
        {
            var data = await repository.Get();
            var output = await service.MultipleToDto<Hall, HallDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetHallById(IRepository<Hall> repository, IService service, int id)
        {
            var data = await repository.GetById(id);
            if (data == null) { return TypedResults.NotFound("Hall not found"); }
            var output = await service.SingleToDto<Hall, HallDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateHall(IRepository<Hall> repository, IService service, HallPost input)
        {
            if (repository.Get().Result.Any(x => x.HallName == input.Name))
            {
                return TypedResults.BadRequest("Hall already exists.");
            }
            Hall hall = new Hall()
            {
                HallName = input.Name,
                HallDesc = input.Desc,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var data = await repository.Create(hall);
            var output = await service.SingleToDto<Hall, HallDto>(data);
            return TypedResults.Created($"/{data.Id}", output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateHall(IRepository<Hall> repository, IService service, int id, HallPut input)
        {
            Hall hall = await repository.GetById(id);
            if (repository.Get().Result.Any(x => x.HallName == input.Name) && hall.HallName != input.Name)
            {
                return TypedResults.BadRequest("Hall already exists.");
            }
            if (hall == null) { return TypedResults.NotFound("Hall not found"); }
            hall.HallName = input.Name;
            hall.HallDesc = input.Desc;
            hall.UpdatedAt = DateTime.UtcNow;
            var data = await repository.Update(hall);
            var output = await service.SingleToDto<Hall, HallDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteHall(IRepository<Hall> repository, IService service, int id)
        {
            if (await repository.GetById(id) == null) { return TypedResults.NotFound("Hall not found"); }
            var data = await repository.Delete(id);
            var output = await service.SingleToDto<Hall, HallDto>(data);
            return TypedResults.Ok(output);
        }
    }
}