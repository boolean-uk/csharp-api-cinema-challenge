using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapPost("/movies", CreateMovie);
            app.MapGet("/movies", GetAllMovies);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies", DeleteMovie);
        }

        private static async Task<IResult> GetAllMovies(IMovieRepository movieRepository)
        {
            return TypedResults.Ok(MovieResponseDTO.FromRepository(await movieRepository.GetAllMovies()));
        }

        private static async Task<IResult> CreateMovie(IMovieRepository movieRepository, MoviePostPayload payload, IScreeningRepository screeningRepository)
        {
            //lägg till alla if satser

            Movie? movie = await movieRepository.CreateAMovie(payload.title, payload.rating, payload.description, payload.runtimeMins);

            if (payload.screenings != null)
            {
                foreach (MovieScreeningPostPayload screening in payload.screenings)
                {
                    await screeningRepository.CreateScreening(movie.Id, screening.screen_number, screening.capacity, screening.startsAt);
                }
            }

            return TypedResults.Created("created", MovieResponseDTO.FromRepository(movie));
        }

        private static async Task<IResult> UpdateMovie(IMovieRepository movieRepository, MovieUpdatePayload payload)
        {
            //lägg till alla if satser
            Movie? movie = await movieRepository.UpdateMovie(payload.id, payload.title, payload.rating, payload.description, payload.runtimeMins);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Created("created", MovieResponseDTO.FromRepository(movie));
        }

        private static async Task<IResult>DeleteMovie(IMovieRepository movieRepository, int movieid){
            Movie? movie = await movieRepository.DeleteMovie(movieid);
            if(movie == null){
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(MovieResponseDTO.FromRepository(movie));
        }
    }
}
