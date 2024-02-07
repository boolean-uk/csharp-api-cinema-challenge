using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var MovieGroup = app.MapGroup("movie");

            MovieGroup.MapPost("/", CreateMovie);
            MovieGroup.MapGet("/", GetAllMovies);
            MovieGroup.MapPut("/{id}", UpdateMovie);
            MovieGroup.MapDelete("/{id}", DeleteMovie);

        }


        public static async Task<IResult> CreateMovie([FromBody] MoviePayload payload, [FromServices] IRepository repository)
        {
            Movie? movie = await repository.CreateMovie(payload.Title, payload.Rating, payload.Description, payload.runTime);
            if (movie == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            MovieDto movieDto = new MovieDto(movie);

            return TypedResults.Created($"/Movie {movie.Id}", movieDto);
        }

        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            var movies = await repository.GetAllMovies();
            List<Object> result = new List<Object>();


            foreach (Movie movie in movies)
            {
                var newMovie = new MovieDto(movie);
                result.Add(newMovie);
            }

            return TypedResults.Ok(result);
        }


        //********************************** Update a movie ********************************************
        public static async Task<IResult> UpdateMovie(int movieId, [FromBody] MoviePayload moviepayload, [FromServices] IRepository repository)
        {

            var updatedMovie = await repository.UpdateMovie(movieId, moviepayload.Title, 
                moviepayload.Rating, moviepayload.Description, moviepayload.runTime );


            if (updatedMovie == null)
            {
                return Results.NotFound($"movie with id {movieId} not found.");
            }

            var movieDto = new MovieDto(updatedMovie);

            repository.SaveChanges();

            return Results.Created($"",movieDto);
        }


        //********************************** Delete a movie ******************************

        public static async Task<IResult> DeleteMovie(int movieId, IRepository repository)
        {
            Movie movie = await repository.DeleteMovie(movieId, PreloadPolicy.PreloadRelations);
            if (movie == null)
            {
                return Results.NotFound("Movie does not exist");
            }
            var movieDto = new MovieDto(movie);
            repository.SaveChanges();


            return TypedResults.Ok(movieDto);
        }



    }
}
