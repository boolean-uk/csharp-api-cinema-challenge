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
                    RuntimeMins = movie.RuntimeMins, TimeCreated = movie.TimeCreated, TimeUpdated = movie.TimeUpdated
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
                RuntimeMins = inMovie.RuntimeMins, TimeCreated = DateTime.UtcNow, TimeUpdated = DateTime.UtcNow
            };

            var acceptedMovie = await repository.Insert(movie);


            return TypedResults.Ok(acceptedMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieDTO inMovie)
        {
            var originalData = await repository.GetById(id);
            if (originalData == null) return TypedResults.NotFound();

            if (inMovie.Title != "string") originalData.Title = inMovie.Title;
            if (inMovie.Description != "string") originalData.Description = inMovie.Description;
            if (inMovie.Rating != "string") originalData.Rating = inMovie.Rating;
            if (inMovie.RuntimeMins != 0) originalData.RuntimeMins = inMovie.RuntimeMins;

            var acceptedMovie = await repository.Update(originalData);

            MovieDTO acceptedMovieDTO = new MovieDTO()
            {
                Description = acceptedMovie.Description, Rating = acceptedMovie.Rating,
                RuntimeMins = acceptedMovie.RuntimeMins, TimeUpdated = acceptedMovie.TimeUpdated,
                TimeCreated = acceptedMovie.TimeCreated, Title = acceptedMovie.Title
            };

            return TypedResults.Ok(acceptedMovieDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var acceptedMovie = await repository.Delete(id);

            return TypedResults.Ok(acceptedMovie);
        }
    }
}
