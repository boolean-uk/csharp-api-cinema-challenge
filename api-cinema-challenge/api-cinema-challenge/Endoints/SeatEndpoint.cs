using api_cinema_challenge.Model;
using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endoints
{
    public static class SeatEndpoint
    {
        public static void ConfigureSeatEndpoint(this WebApplication app)
        {
            var seatGroup = app.MapGroup("seat");

            seatGroup.MapGet("/seats" , GetSeats);
            seatGroup.MapGet("/seats/{id}" , GetSeatById);
            seatGroup.MapPost("/seats" , CreateSeat);
            seatGroup.MapPut("/seats/{id}" , UpdateSeat);
            seatGroup.MapDelete("/seats/{id}" , DeleteSeat);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetSeats(ISeatRepository repository)
        {
            return TypedResults.Ok(await repository.GetAllSeats());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetSeatById(ISeatRepository repository , int id)
        {
            var seat = await repository.GetSeat(id);
            if(seat == null)
            {
                return Results.NotFound($"Seat with ID {id} not found.");
            }
            return Results.Ok(seat);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateSeat(ISeatRepository repository , SeatDto seatDto)
        {
            var seat = new Seat
            {
                SeatNumber = seatDto.SeatNumber ,
                RowNumber = seatDto.RowNumber ,
                ScreenId = seatDto.ScreenId
            };

            seat = await repository.CreateSeat(seat);
            return Results.Created($"/seats/{seat.Id}" , seat);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateSeat(ISeatRepository repository , int id , SeatDto seatDto)
        {
            var seat = new Seat
            {
                SeatNumber = seatDto.SeatNumber ,
                RowNumber = seatDto.RowNumber ,
                ScreenId = seatDto.ScreenId
            };

            seat = await repository.UpdateSeat(id , seat);
            if(seat == null)
            {
                return Results.NotFound($"Seat with ID {id} not found.");
            }
            return Results.Ok(seat);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteSeat(ISeatRepository repository , int id)
        {
            var seat = await repository.DeleteSeat(id);
            if(seat == null)
            {
                return Results.NotFound($"Seat with ID {id} not found.");
            }
            return Results.Ok(seat);
        }
    }
}
