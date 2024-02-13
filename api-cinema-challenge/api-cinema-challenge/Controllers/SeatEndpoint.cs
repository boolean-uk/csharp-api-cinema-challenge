using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Controllers
{
    public static class SeatEndpoint
    {
        //TODO:  add additional endpoints in here according to the requirements in the README.md 
        public static void ConfigureSeatEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/seats", GetSeats);
            cinemaGroup.MapGet("/seat/{id}", GetSeatById);
            cinemaGroup.MapPost("/seat", CreateSeat);
            cinemaGroup.MapPut("/seat/{id}", UpdateSeat);
            cinemaGroup.MapDelete("/seat/{id}", DeleteSeat);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetSeats(IRepository<Seat> repository, IService service)
        {
            var data = await repository.Get();
            var output = await service.MultipleToDto<Seat, SeatDto>(data);
            var outputPayload = new Payload<IEnumerable<SeatDto>> { data = output };
            return TypedResults.Ok(outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetSeatById(IRepository<Seat> repository, IService service, int id)
        {
            var data = await repository.GetById(id);
            if (data == null) { return TypedResults.NotFound("Seat not found"); }
            var output = await service.SingleToDto<Seat, SeatDto>(data);
            var outputPayload = new Payload<SeatDto> { data = output };
            return TypedResults.Ok(outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateSeat(IRepository<Seat> repository, IService service, SeatPost input)
        {
            if (repository.Get().Result.Any(x => x.HallId == input.HallId && x.SeatNumber == input.SeatNumber && x.SeatRow == input.SeatRow))
            {
                return TypedResults.BadRequest("Seat already exists.");
            }
            Seat seat = new Seat()
            {
                HallId = input.HallId,
                SeatNumber = input.SeatNumber,
                SeatRow = input.SeatRow,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var data = await repository.Create(seat);
            var output = await service.SingleToDto<Seat, SeatDto>(data);
            var outputPayload = new Payload<SeatDto> { data = output };
            return TypedResults.Created($"/{data.Id}", outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateSeat(IRepository<Seat> repository, IService service, int id, SeatPut input)
        {
            Seat seat = await repository.GetById(id);
            if (repository.Get().Result.Any(x => x.HallId == seat.HallId && x.SeatNumber == input.SeatNumber && x.SeatRow == input.SeatRow))
            {
                return TypedResults.BadRequest("Seat already exists.");
            }
            if (seat == null) { return TypedResults.NotFound("Seat not found"); }
            seat.SeatNumber = input.SeatNumber;
            seat.SeatRow = input.SeatRow;
            seat.UpdatedAt = DateTime.UtcNow;
            var data = await repository.Update(seat);
            var output = await service.SingleToDto<Seat, SeatDto>(data);
            var outputPayload = new Payload<SeatDto> { data = output };
            return TypedResults.Ok(outputPayload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteSeat(IRepository<Seat> repository, IService service, int id)
        {
            if (await repository.GetById(id) == null) { return TypedResults.NotFound("Seat not found"); }
            var data = await repository.Delete(id);
            var output = await service.SingleToDto<Seat, SeatDto>(data);
            var outputPayload = new Payload<SeatDto> { data = output };
            return TypedResults.Ok(outputPayload);
        }
    }
}