using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningEndpoint
    {
        // Base path of the api call, used for the created call...
        private static string _path = AppContext.BaseDirectory;
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screening = app.MapGroup("movies/{id}/screenings");

            screening.MapPost("", CreateScreening);
            screening.MapGet("", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, int id, ScreeningView view)
        {
            if (await repository.Get([], s => s.ScreenId == view.ScreenNumber && s.StartsAt == DateTime.Parse(view.StartsAt).ToUniversalTime()) != null)
            {
                return TypedResults.BadRequest(new Payload<string>() { Status = "failure", Data = "This screening slot is already taken" });
            }
            DateTime creationTime = DateTime.UtcNow;
            var model = new Screening()
            {
                MovieId = id,
                ScreenId = view.ScreenNumber,
                Capacity = view.Capacity,
                StartsAt = DateTime.Parse(view.StartsAt).ToUniversalTime(),
                CreatedAt = creationTime,
                UpdatedAt = creationTime
            };
            var result = await repository.Create(["Movie"], model);
            var resultDTO = new ScreeningDTO(result);

            var payload = new Payload<ScreeningDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_path, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, int id)
        {
            var resultList = await repository.GetAll(["Movie"], s => s.MovieId == id);
            var resultDTOs = new List<ScreeningDTO>();
            foreach (var result in resultList)
            {
                resultDTOs.Add(new ScreeningDTO(result));
            }

            var payload = new Payload<List<ScreeningDTO>>() { Status = "success", Data = resultDTOs };
            return TypedResults.Ok(payload);
        }
    }
}
