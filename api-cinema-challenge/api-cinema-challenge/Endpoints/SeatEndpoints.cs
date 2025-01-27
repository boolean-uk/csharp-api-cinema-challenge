using api_cinema_challenge.DTO;
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
            group.MapPut("/{id}", UpdateSeat);
            group.MapDelete("/{id}", DeleteSeat);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetSeats(IRepository<Seat, int> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Seat> seats = await repository.GetAll(
                    //q => q.Include(x => x.Tickets.Where(t => t.Screening.StartingAt > DateTime.UtcNow)).ThenInclude(x => x.Screening).ThenInclude(x => x.Movie),
                    //q => q.Include(x => x.Tickets.Where(t => t.Screening.StartingAt > DateTime.UtcNow)).ThenInclude(x => x.Screening).ThenInclude(x => x.Screen),
                    //q => q.Include(x => x.Tickets.Where(t => t.Screening.StartingAt > DateTime.UtcNow)).ThenInclude(x => x.Seat)
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
                Seat seat = await repository.Get(id
                    //q => q.Include(x => x.Tickets).ThenInclude(x => x.Screening).ThenInclude(x => x.Movie),
                    //q => q.Include(x => x.Tickets).ThenInclude(x => x.Screening).ThenInclude(x => x.Screen),
                    //q => q.Include(x => x.Tickets).ThenInclude(x => x.Seat)
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
            IRepository<Seat, int> seatRepository,
            IMapper mapper,
            SeatPost entity)
        {
            try
            {
                Seat seat = await repository.Add(new Seat
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email,
                    Phone = entity.Phone,
                });
                seat = await seatRepository.Add(seat);
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
        public static async Task<IResult> UpdateSeat(
            IRepository<Seat, int> repository,
            IRepository<Seat, int> seatRepository,
            IMapper mapper,
            int id,
            SeatPut entity)
        {
            try
            {
                Seat seat = await repository.Get(id);
                if (entity.FirstName != null) seat.FirstName = entity.FirstName;
                if (entity.LastName != null) seat.LastName = entity.LastName;
                if (entity.Email != null) seat.Email = entity.Email;
                if (entity.Phone != null) seat.Phone = entity.Phone;
                seat = await seatRepository.Update(seat);
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
            IRepository<Seat, int> seatRepository,
            IMapper mapper,
            int id)
        {
            try
            {
                Seat seat = await seatRepository.Delete(id);
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
