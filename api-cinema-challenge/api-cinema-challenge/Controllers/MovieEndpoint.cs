using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("/movies");
            movieGroup.MapGet("", GetMovies);
            movieGroup.MapGet("/{id}", GetMovieByID);
            movieGroup.MapPost("", CreateMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
        }

        public static async Task<IResult> GetMovies(IMovieRepository movieRepository)
        {
            return TypedResults.Ok(new MovieListOutput("success", await movieRepository.GetMovies()));
        }
        public static async Task<IResult> GetMovieByID(IMovieRepository movieRepository, int id)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");
            return TypedResults.Ok(movie);

        }
        public static async Task<IResult> CreateMovie(IMovieRepository movieRepository, MoviePayload payload)
        {
            if (payload.Title == null || payload.Title == "")
                return TypedResults.BadRequest("Please provide a title");
            if (payload.Rating == null || payload.Rating == "")
                return TypedResults.BadRequest("Please provide a rating");
            if (payload.Description == null || payload.Description == "")
                return TypedResults.BadRequest("Please provide a description");
            Movie movie = await movieRepository.CreateMovie(payload.Title, payload.Rating, payload.Description, payload.RuntimeMins, payload.Screenings);
            return TypedResults.Created("", new MovieOutput("success", movie));
        }
        public static async Task<IResult> UpdateMovie(IMovieRepository movieRepository, int id, MoviePayload payload)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");
            Movie updatedMovie = await movieRepository.UpdateMovie(movie, payload.Title, payload.Rating, payload.Description, payload.RuntimeMins);
            return TypedResults.Created("", new MovieOutput("success", updatedMovie));
        }
        public static async Task<IResult> DeleteMovie(IMovieRepository movieRepository, int id)
        {
            Movie? movie = await movieRepository.GetMovieByID(id);
            if (movie is null) return TypedResults.NotFound($"Movie {id} doesn't exist");
            await movieRepository.DeleteMovie(movie);
            return TypedResults.Ok(new MovieOutput("success", movie));
        }


    }
}
