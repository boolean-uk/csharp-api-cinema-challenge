

using api_cinema_challenge.DTO;
using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var MovieGroup = app.MapGroup("/Movies");

            MovieGroup.MapPost("/", CreateMovie);
            MovieGroup.MapGet("/", GetAllMovies);
            MovieGroup.MapGet("/{id}", GetAnMovie);
            MovieGroup.MapPut("/{id}", UpdateMovie);
            MovieGroup.MapDelete("/{id}", DeleteAMovie);
            MovieGroup.MapPost("/{id}/Screenings", CreateAScreening);
            MovieGroup.MapGet("/{id}/Screenings", GetAllScreenings);
        }

        private static async Task<IResult> GetAllScreenings(IScreening<Screening> repository, int id)
        {
            var entites = await repository.GetAllEntities(id);
            Payload<List<GetScreeningDTO>> payload = new();
            payload.load = new();
            foreach (Screening screening in entites)
            {
                payload.load.Add(TransformDTO.ToScreeningDTO(screening));
            }
            payload.Status = "success";

            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> CreateAScreening(IScreening<Screening> repository, PostScreeningDTO screeningDTO, int id)
        {
            Screening screening = TransformDTO.ToScreening(screeningDTO, id);

            var entity = await repository.CreateEntity(screening);
            var result = TransformDTO.ToScreeningDTO(entity);

            Payload<GetScreeningDTO> payload = new();

            payload.load = result;
            payload.Status = "success";

            return TypedResults.Created("Created",payload);
        }

        public static async Task<IResult> GetAnMovie(IMovie<Movie> repository, int id)
        {
            var result = await repository.GetAnEntityById(id);

            return TypedResults.Ok(result);
        }

        public static async Task<IResult> CreateMovie(IMovie<Movie> repository, PostMovieDTO movieDTO)
        {
            try
            {
                Movie movie = TransformDTO.ToMovie(movieDTO);
                var entity = await repository.CreateEntity(movie);
                GetMovieDTO getMovieDTO = TransformDTO.ToMovieDTO(entity);


                Screening screening = TransformDTO.ToScreeningFromMovie(movieDTO, entity.Id);
                var contains = await repository.CheckIfEntityHasAScreening(entity.Id, screening.StartsAt);


                if (contains && movieDTO.Screening.capacity != 0)
                {
                    await repository.CreateEntityScreening(screening);
                }

                return TypedResults.Created("Created", getMovieDTO);
            }

            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteAMovie(IMovie<Movie> repository, int id)
        {
            var entity = await repository.DeleteEntity(id);
            Payload<Movie> payload = new Payload<Movie>();
            payload.load = entity;
            payload.Status = "Success";

            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> UpdateMovie(IMovie<Movie> repository, UpdateMovieDTO movieDTO, int id)
        {
            var entity = await repository.UpdateEntity(movieDTO,id);
            Payload<GetMovieDTO> payload = new();
            payload.load = TransformDTO.ToMovieDTO(entity);

            if (payload != default(Payload<GetMovieDTO>))
                payload.Status = "Success";

            return TypedResults.Created("Created", payload);
        }

        public static async Task<IResult> GetAllMovies(IMovie<Movie> repository)
        {
            var movies = await repository.GetAllEntities();
            Payload<List<GetMovieDTO>> payload = new Payload<List<GetMovieDTO>>();
            payload.load = new();

            foreach (var movie in movies)
            {
                GetMovieDTO movieDTO = TransformDTO.ToMovieDTO(movie);
                payload.load.Add(movieDTO);
            }

            if (payload.load.Count > 0)
                payload.Status = "Success";

            return TypedResults.Ok(payload);
        }

    }
}
