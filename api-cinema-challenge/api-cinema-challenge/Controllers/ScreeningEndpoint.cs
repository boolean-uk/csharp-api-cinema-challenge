using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {

        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var ScreeningGroup = app.MapGroup("screening");

            ScreeningGroup.MapPost("/post", CreateScreening);
            ScreeningGroup.MapGet("/get", GetScreenings);
            


        }


        public static async Task<IResult> CreateScreening(IScreeningRepository screeningRepository, AddScreeningDTO payload, int movieId)
        {
            
            Screening screening = new()
            {
                ScreenNumber = payload.ScreenNumber,
                StartsAt = payload.StartsAt,
                Capacity = payload.Capacity
            };
            await screeningRepository.CreateScreening(screening, movieId);

            payload.CreatedAt = screening.CreatedAt;
            payload.UpdatedAt = screening.UpdatedAt;

         

            var response = new ApiResponse<AddScreeningDTO>()
            {
                Data = payload,
                Status = "Success"
            };
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> GetScreenings(IScreeningRepository screeningRepository, int movieId)
        {
           
            List<ScreeningDTO> screenings = new();

            var originalScreenings = await screeningRepository.GetScreenings(movieId);

            foreach (var screening in originalScreenings)
            {
                screenings.Add(new ScreeningDTO
                {
                    Id = screening.Id,
                    ScreenNumber = screening.ScreenNumber,
                    StartsAt = screening.StartsAt,
                    Capacity = screening.Capacity,
                    CreatedAt = screening.CreatedAt,
                    UpdatedAt = screening.UpdatedAt
                });
            }

            var response = new ApiResponse<List<ScreeningDTO>> { Data = screenings, Status = "Success" };
            return TypedResults.Ok(response);
        }
    }
}
