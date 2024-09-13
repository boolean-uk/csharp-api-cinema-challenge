using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            var screenings = app.MapGroup("screenings");
            screenings.MapGet("/", GetScreenings);
            screenings.MapGet("/{id}", GetScreeningsByMovieId);
            screenings.MapPost("/", CreateScreening);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository)
        {
            Response<IEnumerable<ScreeningDTO>> response = new();
            var screenings = await repository.GetAll();
            var screeningsResponse = screenings.Select(s => new ScreeningDTO(s));
            response.Data = screeningsResponse;
            return TypedResults.Ok(response);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private async static Task<IResult> GetScreeningsByMovieId(IRepository<Screening> repository, int movieId)
        {
            Response<IEnumerable<ScreeningDTO>> response = new();
            var screenings = await repository.GetAllById(movieId);
            var screeningResponse = screenings.Select(s => new ScreeningDTO(s));
            response.Data = screeningResponse;
            return TypedResults.Ok(response);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, int movieId, ScreeningPayload model)
        {
            var screenings = await repository.GetAll();

            if (screenings.Any(s => s.ScreenNumber == model.ScreenNumber))
            {
                return TypedResults.BadRequest($"ScreenNumber {model.ScreenNumber} already exists");
            };

            Response<IEnumerable<ScreeningDTO>> response = new();
            List<ScreeningDTO> screeningResponse = new();
            var addScreening = new Screening() { ScreenNumber = model.ScreenNumber, Capacity = model.Capacity, MovieId = movieId, StartsAt = model.StartsAt, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            addScreening = await repository.Add(addScreening);
            screeningResponse.Add(new ScreeningDTO(addScreening));
            response.Data = screeningResponse;
            return TypedResults.Ok(response);
        }

    }
}
