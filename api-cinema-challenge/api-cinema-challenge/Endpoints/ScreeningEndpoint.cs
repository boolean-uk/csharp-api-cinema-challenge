using api_cinema_challenge.Models.Base;
using api_cinema_challenge.Models.InputDTOs;
using api_cinema_challenge.Models.OutputDTOs;
using api_cinema_challenge.Repository.ExtensionRepository;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            app.MapGet("/movies/{movieId}/screenings", GetScreenings);
            app.MapPost("/movies/{movieId}/screenings", CreateScreening);
        }

        private static async Task<IResult> CreateScreening(IRepository<Screening> screeningRepo, IRepository<Movie> movieRepo,  int movieId, ScreeningInputDto inputDto)
        {
            var movie = await movieRepo.GetById(movieId);
            var input = new Screening
            {
                Capacity = inputDto.Capacity,
                ScreenNumber = inputDto.ScreenNumber,
                StartsAt = inputDto.StartsAt,
                MovieId = movieId,
                Movie = movie,
            };

            var inserted = await screeningRepo.Insert(input);
            return TypedResults.Created($"/customers/{inserted.Id}", ScreeningOutputDto.Create(inserted));
        }

        private static async Task<IResult> GetScreenings(IRepository<Screening> repo, int movieId)
        {
            var screenings = await repo.Get();
            return Results.Ok(screenings.Where(s => s.MovieId == movieId).Select(ScreeningOutputDto.Create));

        }
    }

}
