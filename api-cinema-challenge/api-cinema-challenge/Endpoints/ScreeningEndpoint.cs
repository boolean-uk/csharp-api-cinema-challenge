using api_cinema_challange.Models;
using api_cinema_challange.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace api_cinema_challange.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapGet("/screenings", GetAllScreenings);
            app.MapPost("/screenings", CreateScreening);
        }

        private static async Task<IResult> GetAllScreenings(IScreeningRepository screeningRepository)
        {
            return TypedResults.Ok(ScreeningResponseDTO.FromRepository(await screeningRepository.GetAllScreenings()));
        }

        private static async Task<IResult>CreateScreening(IScreeningRepository screeningRepository, IMovieRepository movieRepository, ScreeningPostPayload payload){
            Movie? movie = await movieRepository.GetMovieById(payload.movie_id);
            if (movie == null)
            {
                return TypedResults.NotFound("movie id does not exist");
            }
            Screening? screening = await screeningRepository.CreateScreening(payload.movie_id, payload.screen_number, payload.capacity, payload.startsAt);

            if (screening == null)
            {
                return null;
            }

            return TypedResults.Ok(ScreeningResponseDTO.FromRepository(screening));
        }

    }
}
