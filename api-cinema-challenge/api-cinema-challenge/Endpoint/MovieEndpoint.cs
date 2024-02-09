using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoint
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie/");

            movieGroup.MapGet("get_all", GetMovies);
            movieGroup.MapPost("add", AddMovie);
            movieGroup.MapPut("update/{id}", UpdateMovie);
            movieGroup.MapDelete("delete/{id}", DeleteMovie);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            var movies = await repository.Get();

            List<MovieDTO> moviesDTO = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                moviesDTO.Add(new MovieDTO()
                {
                    Title = movie.Title, Description = movie.Description, Rating = movie.Rating,
                    RuntimeMins = movie.RuntimeMins
                });
            }

            return TypedResults.Ok(moviesDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddMovie(IRepository<Movie> repository, MovieDTO inMovie)
        {
            Movie movie = new Movie()
            {
                Title = inMovie.Title, Description = inMovie.Description, Rating = inMovie.Rating,
                RuntimeMins = inMovie.RuntimeMins
            };

            var acceptedMovie = await repository.Insert(movie);


            return TypedResults.Ok(acceptedMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieDTO inMovie)
        {
            //TODO KEEP ORIGINAL VALUES
            Movie movie = new Movie()
            {
                Id = id,
                Title = inMovie.Title,
                Description = inMovie.Description,
                Rating = inMovie.Rating,
                RuntimeMins = inMovie.RuntimeMins
            };

            var acceptedMovie = await repository.Update(movie);


            return TypedResults.Ok(acceptedMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var acceptedMovie = await repository.Delete(id);

            return TypedResults.Ok(acceptedMovie);
        }
    }
}
