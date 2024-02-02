


using api_cinema_challenge.Data.DTO;
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Endpoints {
    public static class ScreeningEndpoints {
        
        public static void ConfigureScreeningEndpoints(this WebApplication app) {
            var screening = app.MapGroup("/screenings");

            screening.MapGet("/", GetScreenings);
            screening.MapGet("/{Id}", GetScreeningByID);
            screening.MapGet("/{Id}/seats", GetSeats);
            screening.MapPut("/{Id}", UpdateScreening);
            screening.MapPost("/{movieId}", CreateScreening);
            //screening.MapDelete("/{Id}", DeleteScreening);
        }

        private static async Task DeleteScreening(IScreeningRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> GetSeats(IScreeningRepository repository, int id)
        {
            var seats = await repository.GetSeats(id);
            if(seats == null)
                return Results.BadRequest("No Seats Found");
            return TypedResults.Ok(SeatDTO.FromRepository(seats));
        }

        private static async Task<IResult> CreateScreening(IScreeningRepository repository, int movieId, CreateScreeningPayload payload)
        {
            if(payload.Capacity == 0)
                return Results.BadRequest("Capacity cant be 0");
            if(payload.ScreenNumber == 0)
                return Results.BadRequest("Screen number cant be 0");
            if(payload.StartsAt == null)
                return Results.BadRequest("Need a startTime");
            if(payload.EndsAt == null)
                return Results.BadRequest("Needs a endTime");
            if(payload.Seats == null)
                return Results.BadRequest("Needs atleast 1 Seat");

            var screening = repository.CreateScreening(payload.ScreenNumber, movieId, payload.Capacity, payload.StartsAt, payload.EndsAt, payload.Seats);
               
            return TypedResults.Created("Created", new ScreeningBaseDTO(await screening));
        }

        private static async Task UpdateScreening(IScreeningRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> GetScreenings(IScreeningRepository repository)
        {
            return TypedResults.Ok(ScreeningDTO.FromRepository(await repository.GetAllScreenings()));
        }

        private static async Task<IResult> GetScreeningByID(IScreeningRepository repository, int id)
        {
            if(id <= 0)
                return Results.BadRequest("Not a valid Id");
            var Screening = await repository.GetScreening(id);
            if(Screening == null)
                return Results.NotFound("No screening with ID: " + id + " Found");
            
            return TypedResults.Ok(new ScreeningDTO(Screening));

        }
    }
}