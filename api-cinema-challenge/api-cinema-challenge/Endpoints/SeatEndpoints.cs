using api_cinema_challenge.DTO;
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

            group.MapGet($"/{ScreenEndpoints.Path}/{{screenId}}", GetSeats);
            group.MapPost($"/{ScreenEndpoints.Path}/{{screenId}}", CreateSeat);
            group.MapGet($"/{ScreenEndpoints.Path}/{{screenId}}/{{id}}", GetSeat);
            group.MapDelete($"/{ScreenEndpoints.Path}/{{screenId}}/{{id}}", DeleteSeat);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetSeats(IRepository<Seat, int> repository, IMapper mapper, int screenId)
        {
            try
            {
                IEnumerable<Seat> seats = await repository.FindAll(
                    condition: x => x.ScreenId == screenId
                );
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<SeatInternal>>(seats) });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetSeat(IRepository<Seat, int> repository, IMapper mapper, int screenId, int id)
        {
            try
            {
                Seat seat = await repository.Find(x => x.ScreenId == screenId && x.Id == id,
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
            int screenId,
            SeatPost entity)
        {
            try
            {
                SeatType seatType;
                if (!Enum.TryParse(entity.SeatType, true, out seatType))
                    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = $"That is not a valid seat type! Choose one of {string.Join(", ", Enum.GetValues<SeatType>())}" } });
                Screen screen = await screenRepository.Get(screenId, q => q.Include(x => x.Seats));
                Seat seat = await repository.Add(new Seat
                {
                    ScreenId = screen.Id,
                    SeatType = seatType,
                    Screen = screen
                });
                if (screen.Seats.Count >= screen.Capacity)
                {
                    return TypedResults.Created($"{Path}/{seat.Id}", new Payload
                    {
                        Status = "success/warning",
                        Data = new
                        {
                            Object = mapper.Map<SeatView>(seat),
                            Message = $"You have overgone the recommended capacity of this screen! Current seats / capacity: {screen.Seats.Count()} / {screen.Capacity}"
                        }
                        });
                }
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
            int screenId,
            int id)
        {
            try
            {
                Seat seat = await repository.Find(x => x.Id == id && x.ScreenId == screenId, q => q.Include(x => x.Screen));

                await repository.Delete(seat);
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
