using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("/screenings");
            screeningGroup.MapGet("", GetScreenings);
            screeningGroup.MapGet("/{id}", GetScreeningById);
        }

        private static async Task<IResult> GetScreenings(IRepository<Screening> repo)
        {
            var screenings = await repo.Get();
            return Results.Ok(screenings.Select(screening => new {
                screening.Id,
                screening.ScreenNumber,
                screening.Capacity,
                screening.StartsAt,
                screening.CreatedAt,
                screening.UpdatedAt
            }));
        }

        private static async Task<IResult> GetScreeningById(IRepository<Screening> repo, int id)
        {
            var screening = await repo.GetByIdAsync(id);
            if (screening == null) return Results.NotFound();



            return Results.Ok(new
            {
                screening.Id,
                screening.ScreenNumber,
                screening.Capacity,
                screening.StartsAt,
                screening.CreatedAt,
                screening.UpdatedAt
            });
        }

        private static object ScreeningDto(Screening screening)
        {

        }
    }

}
