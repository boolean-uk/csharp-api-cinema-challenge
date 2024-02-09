using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.PostModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using api_cinema_challenge.Models.DTO;

namespace api_cinema_challenge.Controllers
{
    
    public static class MovieEndpoint {

    public static void ConfigureMovieEndpoint(this WebApplication app)
    {
    var movieGroup = app.MapGroup("movies");

        movieGroup.MapGet("/", AllMovies);
        movieGroup.MapPost("/", CreateMovie);    
        movieGroup.MapPut("/{id}", EditMovie);
        movieGroup.MapDelete("/{id}", DeleteMovie);

    }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AllMovies(IRepository<Movie> repository)
        {
            DTO result = new DTO();
            IEnumerable<Movie> movies = await repository.GetAll();
            foreach(Movie movie in movies)
            {
                result.createDtMovie(movie);
            }
            PayLoad<IEnumerable<DtMovie>> pl = new PayLoad<IEnumerable<DtMovie>>(result.Movies);

            return TypedResults.Ok(pl);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, PMMovie model)
        {
            var result = new DTO();
            Movie movie = new Movie() { Title = model.Title, Description = model.Description, Rating = model.Rating, RunTime = model.RunTimeMins };
            result.createDtMovie(await repository.Insert(movie));

            PayLoad<DtMovie> pl = new PayLoad<DtMovie>(result.Movie);

            return TypedResults.Created($"/{pl.data}", pl);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> EditMovie(IRepository<Movie> repository, int id, PMMovie model)
        {
            DTO result = new DTO();
            Movie movie = new Movie() { Id = id, Title = model.Title, Description = model.Description, Rating = model.Rating, RunTime = model.RunTimeMins };
            result.createDtMovie(await repository.Update(movie));
            PayLoad<DtMovie> pl = new PayLoad<DtMovie>(result.Movie);

            return TypedResults.Created($"/{pl.data}", pl);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            DTO result = new DTO();
            result.createDtMovie(await repository.Delete(id));

            PayLoad<DtMovie> pl = new PayLoad<DtMovie>(result.Movie);

            return TypedResults.Ok( pl);
        }

















    }
}