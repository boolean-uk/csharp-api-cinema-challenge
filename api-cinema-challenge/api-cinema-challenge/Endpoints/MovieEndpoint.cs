using api_cinema_challenge.DTO;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movies = app.MapGroup("movies");
            movies.MapGet("/", GetAllMovies);
            movies.MapPost("/", CreateMovie);
            movies.MapPut("/", UpdateMovie);
            movies.MapDelete("/", DeleteMovie);
            movies.MapGet("/{id}/screenings", GetMovieScreenings);
            movies.MapPost("/{id}/screenings", CreateMovieScreening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovieScreening(IRepository repository, int movieId ,ScreeningPostModel screeningPost)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovieScreenings(IRepository repository, int movieId)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            var movies = await repository.GetAllMovies();
            List<MovieDTO> moviesDTO = (from movie in movies select movie.ToMovieDTO()).ToList();

            Payload<List<MovieDTO>> payload = new() { Status = "success", Data = moviesDTO };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel moviePost)
        {
            Movie movie = moviePost.ToMovie();

            movie = await repository.CreateMovie(movie);

            if (moviePost.Screenings is not null)
            {
                foreach(var screeningPost in moviePost.Screenings)
                {
                    var screening = screeningPost.ToScreening(movie.Id);
                    var resultingScreening = await repository.CreateScreening(screening);
                }
            }

            Payload<MovieDTO> payload = new() { Status = "success", Data = movie.ToMovieDTO() };

            return TypedResults.Created("", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, MovieUpdateModel movieUpdate)
        {
            var movie = await repository.GetMovie(movieUpdate.Id);

            if(!string.IsNullOrEmpty(movieUpdate.Title)) movie.Title = movieUpdate.Title;
            if (!string.IsNullOrEmpty(movieUpdate.Description)) movie.Description = movieUpdate.Description;
            if (!string.IsNullOrEmpty(movieUpdate.Rating)) movie.Rating = movieUpdate.Rating;
            if(movieUpdate.RuntimeMins != 0) movie.RuntimeMins = movieUpdate.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            var resultingMovie = await repository.UpdateMovie(movie);

            Payload<MovieDTO> payload = new() { Status = "success", Data= resultingMovie.ToMovieDTO() };

            return TypedResults.Created("", payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var movie = await repository.DeleteMovie(id);

            Payload<MovieDTO> payload = new() { Status = "success", Data = movie.ToMovieDTO() };

            return TypedResults.Ok(payload);
        }
    }
}
