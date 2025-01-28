
using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace workshop.wwwapi.Endpoints
{
    public static class MoviesEndpoint
    {
        public static void ConfigureMoviesEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");
            movies.MapPost("/", CreateAMovie);
            movies.MapGet("/", GetAllMovies);
            movies.MapPut("/{id}", UpdateAMovie);
            movies.MapDelete("/{id}", DeleteAMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAMovie(HttpContext context, IRepository<Movies> repo, IRepository<Screenings> s_repo, Create_Movie dto)
        {
            var movie = Create_Movie.create(dto);

            var entity = await repo.CreateEntry(movie);
            var screenings = Create_Movie.create_screenings(dto,entity.Id);
            foreach (var screening in screenings)
            {
                await s_repo.CreateEntry(screening);
            }

            return TypedResults.Created(context.Get_endpointUrl(entity.Id), Get_Movie.toPayload(entity));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllMovies( IRepository<Movies> repo)
        {
            var entries = await repo.GetEntries();
            return TypedResults.Ok(Get_Movie.toPayload(entries));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateAMovie(HttpContext context, IRepository<Movies> repo, int id, Update_Movie dto)
        {
            var ent = await Update_Movie.update(dto, repo, id);
            return TypedResults.Created(context.Get_endpointUrl(ent.Id), Get_Movie.toPayload(ent));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteAMovie( IRepository<Movies> repo, int id)
        {
            var ent = await Delete_Movie.delete(repo, id);
            return TypedResults.Ok(Get_Movie.toPayload(ent));
        }

    }
}
