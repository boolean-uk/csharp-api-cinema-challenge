using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movie = app.MapGroup("movies");

            movie.MapGet("/", GetAll);
            movie.MapPost("/", Create);
            movie.MapPut("/{id}", Update);
            movie.MapDelete("/{id}", Delete);

        }

        public static MovieGet MovieToMovieGet(Movie m)
        {
            MovieGet movieShow = new MovieGet() { Id = m.Id, Title = m.Title, Rating = m.Rating, Description = m.Description, RunTimeMins = m.RuntimeMins, CreatedAt = m.CreatedAt, UpdatedAt = m.UpdatedAt };
            return movieShow;
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> movieRepo)
        {
            List<MovieGet> response = new List<MovieGet>();
            var results = await movieRepo.GetAll();
            foreach (Movie m in results)
            {
                MovieGet movieShow = MovieToMovieGet(m);
                response.Add(movieShow);
            }
            return TypedResults.Ok(response);
        }

        [Authorize(Roles = "Admin,User")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Movie> movieRepo, MoviePost mModel)
        {
            DateTime time = DateTime.UtcNow.ToUniversalTime();
            Movie newMovie = new Movie()
            {
                Title = mModel.Title,
                Rating = mModel.Rating,
                Description = mModel.Description,
                RuntimeMins = mModel.RunTimeMins,
                CreatedAt = time,
                UpdatedAt = time
            };
            await movieRepo.Insert(newMovie);
            return TypedResults.Created($"Created object with id: {newMovie.Id}");
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Update(IRepository<Movie> movieRepo, int id, MoviePost mModel)
        {
            Movie? mTarget = await movieRepo.GetById(id);

            if (mTarget != null)
            {
                DateTime time = DateTime.UtcNow.ToUniversalTime();
                mTarget.Title = mModel.Title;
                mTarget.Rating = mModel.Rating;
                mTarget.Description = mModel.Description;
                mTarget.RuntimeMins = mModel.RunTimeMins;
                mTarget.UpdatedAt = time;

                await movieRepo.Update(mTarget);
                return TypedResults.Created($"Updated object with id: {id}");
            }
            return TypedResults.NotFound();
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public static async Task<IResult> Delete(IRepository<Movie> movieRepo, int id)
        {
            Movie? mTarget = await movieRepo.GetById(id);
            if (mTarget != null)
            {
                await movieRepo.Delete(id);
                return TypedResults.Ok(MovieToMovieGet(mTarget));
            }
            return TypedResults.NotFound();
        }
        
    }
}

