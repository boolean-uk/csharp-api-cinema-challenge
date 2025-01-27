﻿using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class SeatEndpoints
    {
        public static string Path { get; private set; } = "seats";
        public static void ConfigureSeatsEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetSeats);
            group.MapPost("/", CreateSeat);
            group.MapGet("/{id}", GetSeat);
            group.MapDelete("/{id}", DeleteSeat);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetSeats(IRepository<Seat, int> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Seat> seats = await repository.GetAll(
                    q => q.Include(x => x.Screen)
                );
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<SeatView>>(seats) });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetSeat(IRepository<Seat, int> repository, IMapper mapper, int id)
        {
            try
            {
                Seat seat = await repository.Get(id,
                    q => q.Include(x => x.Screen)
                );
                return TypedResults.Ok(mapper.Map<SeatView>(seat));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateSeat(
            IRepository<Seat, int> repository,
            IRepository<Screen, int> screenRepository,
            IMapper mapper,
            SeatPost entity)
        {
            try
            {
                SeatType seatType;
                if (!Enum.TryParse(entity.SeatType, true, out seatType))
                    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = $"That is not a valid appointment type! Choose one of {string.Join(", ", Enum.GetValues<SeatType>())}" } });
                Screen screen = await screenRepository.Get(entity.ScreenId);
                Seat seat = await repository.Add(new Seat
                {
                    ScreenId = screen.Id,
                    SeatType = seatType,
                    Screen = screen
                });
                seat = await repository.Add(seat);
                return TypedResults.Created($"{Path}/{seat.Id}", new Payload
                {
                    Data = mapper.Map<SeatView>(seat)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteSeat(
            IRepository<Seat, int> repository,
            IMapper mapper,
            int id)
        {
            try
            {
                Seat seat = await repository.Get(id, q => q.Include(x => x.Screen));

                await repository.Delete(id);
                return TypedResults.Created($"{Path}/{seat.Id}", new Payload { Data = mapper.Map<SeatView>(seat) });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
