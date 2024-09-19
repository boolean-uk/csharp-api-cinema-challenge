using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Reflection;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapGet("/", GetMovies);
            movies.MapPost("/moviecreate", CreateMovie);
            movies.MapPut("/updatemovie", UpdateMovie);
            movies.MapDelete("/deletemovie", DeleteMovie);

        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();

            if (movies == null) { return TypedResults.NotFound(); }

            List<MovieDTO> response = new List<MovieDTO>();

            foreach (Movie movie in movies)
            {
                MovieDTO movieDTO = new MovieDTO();
                movieDTO.Id = movie.Id;
                movieDTO.Title = movie.Title;
                movieDTO.Rating = movie.Rating;
                movieDTO.Description = movie.Description;
                movieDTO.RunTimeMins = movie.RunTimeMins;
                movieDTO.CreatedAt = movie.CreatedAt;
                movieDTO.UpdatedAt = movie.UpdatedAt;

                response.Add(movieDTO);
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel model)
        {
            try
            {
                var createdmovie = await repository.CreateMovie(new Movie()
                {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description,
                    RunTimeMins = model.RunTimeMins,

                });

                if (createdmovie == null) { return TypedResults.NotFound(); }

                MovieDTO moviedto = new MovieDTO()
                {
                    Id = createdmovie.Id,
                    Title = createdmovie.Title,
                    Rating = createdmovie.Rating,
                    Description = createdmovie.Description,
                    RunTimeMins = createdmovie.RunTimeMins,
                    CreatedAt = createdmovie.CreatedAt,
                    UpdatedAt = createdmovie.UpdatedAt,
                };

                return TypedResults.Created("/", moviedto);
            }
            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> UpdateMovie(IRepository repository, MoviePutModel model, int id)
        {
            try
            {
                var movietoupdate = await repository.GetMovieById(id);

                if (movietoupdate == null) { return TypedResults.NotFound(); }

                movietoupdate.Title = model.Title;
                movietoupdate.Rating = model.Rating;
                movietoupdate.Description = model.Description;
                movietoupdate.RunTimeMins = model.RunTimeMins;

                await repository.UpdateMovie(movietoupdate);

                MovieDTO moviedto = new MovieDTO()
                {
                    Title = movietoupdate.Title,
                    Rating = movietoupdate.Rating,
                    Description = movietoupdate.Description,
                    RunTimeMins = movietoupdate.RunTimeMins,
                    CreatedAt = movietoupdate.CreatedAt,
                    UpdatedAt = movietoupdate.UpdatedAt,

                };

                return TypedResults.Ok(moviedto);

            }

            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);

            }
        }

        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {

            try
            {
                var movietodelete = await repository.GetMovieById(id);

                if (movietodelete == null) { return TypedResults.NotFound(); }

                await repository.DeleteMovie(movietodelete.Id);

                MovieDTO movieDTO = new MovieDTO()
                {
                    Title = movietodelete.Title,
                    Rating = movietodelete.Rating,
                    Description = movietodelete.Description,
                    RunTimeMins = movietodelete.RunTimeMins,
                    CreatedAt = movietodelete.CreatedAt,
                    UpdatedAt = movietodelete.UpdatedAt,
                };

                return TypedResults.Ok(movieDTO);

            }

            catch (Exception ex) { return TypedResults.Problem(ex.Message); } 




        }


    }
}
