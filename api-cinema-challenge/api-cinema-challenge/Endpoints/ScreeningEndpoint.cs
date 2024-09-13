using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.Payload;
using api_cinema_challenge.Models.Response;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screening = app.MapGroup("/movies");
            screening.MapPost("/{movieid}/screenings", CreateScreening);
            screening.MapGet("/{movieid}/screenings", GetScreenings);
        }

        private static async Task<IResult> CreateScreening(IRepository<Screening, ScreeningPayload> repo, int movieid, ScreeningPayload payload)
        {
            ScreeningRepository screeningRepository = (ScreeningRepository)repo;
            Screening screening = await screeningRepository.CreateOnId(payload, movieid);

            ScreeningDTO dto = new ScreeningDTO()
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAT = screening.CreatedAT,
                UpdatedAT = screening.UpdatedAT
            };
            return TypedResults.Created("/", new Response("success", dto));

        }

        private static async Task<IResult> GetScreenings(IRepository<Screening, ScreeningPayload> repo, int movieid)
        {
            ScreeningRepository screeningRepository = (ScreeningRepository) repo;
            IEnumerable<Screening> screenings = await screeningRepository.GetById(movieid);

            IEnumerable<ScreeningDTO> DTOs = screenings.Select(s => new ScreeningDTO
            {
                Id = s.Id,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt,
                CreatedAT = s.CreatedAT,
                UpdatedAT = s.UpdatedAT,

            });

            return TypedResults.Ok(new Response("success", DTOs));
        }
    }
}
