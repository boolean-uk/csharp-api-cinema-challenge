using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieAPI
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var moviesGroup = app.MapGroup("movies");
            moviesGroup.MapGet("/", GetAllMovies);
            moviesGroup.MapPost("/", CreateMovie);
            moviesGroup.MapGet("/{id}", GetMovieById);
            moviesGroup.MapDelete("/{id}", DeleteMovieById);
            moviesGroup.MapPost("/{id}/screenings", CreateScreening);
            moviesGroup.MapGet("/{id}/screenings", GetMovieScreenings);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovieScreenings(IRepository<Movie> repository, int id)
        {
            var response = await repository.GetScreeningsByMovieId(id);
            if (response != null)
            {
                List<ScreeningDTO> screenings = new List<ScreeningDTO>();
                foreach (var screening in response)
                {
                    screenings.Add(new ScreeningDTO(screening));
                }
                return TypedResults.Ok(screenings);
            } return TypedResults.NotFound("No screenings found");

        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, int id, ScreeningPost screeningPost)
        {
            var s = new Screening
            {
                Number = screeningPost.Number,
                Capacity = screeningPost.Capacity,
                StartsAt = screeningPost.StartsAt,
                CreatedAt = DateTime.UtcNow,
                MovieId = id
            };
            var response = await repository.Insert(s);
            if (response != null)
            {
                return TypedResults.Created("", new ScreeningDTO(response));
            } return TypedResults.BadRequest("Failed to create");

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var response = await repository.GetAll();
            List<MovieDTO> movies = new List<MovieDTO>();
            if (response.Count() > 0)
            {
                foreach (var movie in response)
                {
                    movies.Add(new MovieDTO(movie));

                }
                return TypedResults.Ok(movies);
            }
            else return TypedResults.NotFound("No movies or another problem");
            // Should return something else
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MoviePost movie)
        {
            // Turn customerpost into customer before adding to db
            var m = new Movie
            {
                Title = movie.Title,
                Description = movie.Description,
                RuntimeMin = movie.RuntimeMin,
                IMDBRating = movie.IMDBRating
            };
            var response = await repository.Insert(m);
            if (response != null)
            {
                var mDTO = new MovieDTO(response);
                return TypedResults.Created("",mDTO);
            }
            else return TypedResults.BadRequest("Could not create");
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovieById(IRepository<Movie> repository, int id)
        {
            var response = await repository.GetById(id);
            if (response != null)
            {
                return TypedResults.Ok(new MovieDTO(response));
            }
            return TypedResults.NotFound("Movie does not exist");

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovieById(IRepository<Movie> repository, int id)
        {
            var response = await repository.DeleteById(id);
            if (response != null)
            {
                return TypedResults.Ok(new MovieDTO(response));
            }
            return TypedResults.NotFound("Movie not deleted");
        }

    }
}
