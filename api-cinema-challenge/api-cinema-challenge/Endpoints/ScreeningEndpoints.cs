using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screenings = app.MapGroup("screenings");

            screenings.MapPost("/", CreateScreening);
            screenings.MapGet("/", GetScreenings);
            screenings.MapGet("/ByMovieId/{id}", GetScreeningsByMovie);
            screenings.MapGet("/{id}", GetScreeningById);
            screenings.MapPut("/{id}", UpdateScreening);
            screenings.MapDelete("/{id}", DeleteScreening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(IScreeningRepository screeningRepository, IMovieRepository movieRepository, PostScreeningDTO model)
        {
            try
            {
                var targetMovie = await movieRepository.GetMovieById(model.MovieId);
                if (targetMovie == null)
                {
                    return TypedResults.NotFound("Related movie not found");
                }

                var newScreening = await screeningRepository.CreateScreening(new Screening()
                {
                    ScreenNumber = model.ScreenNumber,
                    Capacity = model.Capacity,
                    MovieId = model.MovieId,
                    StartsAt = model.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });

                Payload<ResponseScreeningDTO> payload = new Payload<ResponseScreeningDTO>();
                payload.data = Mapper.MapToDTO(newScreening);
                return TypedResults.Created($"https://localhost:7054/Screenings/{payload.data.Id}", payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid Screening object");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetScreenings(IScreeningRepository repository)
        {
            var results = await repository.GetScreenings();
            List<Screening> screenings = results.ToList();
            if (screenings.Count <= 0)
            {
                return TypedResults.NoContent();
            }

            Payload<List<ResponseScreeningDTO>> payload = new Payload<List<ResponseScreeningDTO>>();
            List<ResponseScreeningDTO> responseScreenings = new List<ResponseScreeningDTO>();

            foreach (Screening s in screenings)
            {
                responseScreenings.Add(Mapper.MapToDTO(s));
            }

            payload.data = responseScreenings;

            return TypedResults.Ok(payload.data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningsByMovie(IScreeningRepository repository, int id)
        {
            try
            {
                var result = await repository.GetScreeningsByMovie(id);
                if (result is null)
                {
                    return TypedResults.NotFound("Related movie not Found");
                }

                Payload<List<ResponseScreeningDTO>> payload = new Payload<List<ResponseScreeningDTO>>();
                List<ResponseScreeningDTO> responseScreenings = new List<ResponseScreeningDTO>();

                foreach (Screening s in result)
                {
                    responseScreenings.Add(Mapper.MapToDTO(s));
                }
                payload.data = responseScreenings;

                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningById(IScreeningRepository repository, int id)
        {
            try
            {
                var result = await repository.GetScreeningById(id);
                if (result is null)
                {
                    return TypedResults.NotFound("Screening Not Found");
                }

                Payload<ResponseScreeningDTO> payload = new Payload<ResponseScreeningDTO>();
                payload.data = Mapper.MapToDTO(result);

                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateScreening(IScreeningRepository screeningRepository, IMovieRepository movieRepository, int id, PutScreeningDTO model)
        {
            try
            {
                var screeningTarget = await screeningRepository.GetScreeningById(id);
                if (screeningTarget is null)
                {
                    return TypedResults.NotFound("Screening Not Found");
                }

                var movieTarget = await movieRepository.GetMovieById(model.MovieId);
                if (movieTarget is null)
                {
                    return TypedResults.NotFound("Movie Not Found");
                }

                var updatedTarget = await screeningRepository.UpdateScreening(id, new Screening()
                {
                    ScreenNumber = model.ScreenNumber,
                    Capacity = model.Capacity,
                    StartsAt = model.StartsAt,
                    MovieId = model.MovieId,
                    UpdatedAt = DateTime.UtcNow
                });

                Payload<ResponseScreeningDTO> payload = new Payload<ResponseScreeningDTO>();
                payload.data = Mapper.MapToDTO(updatedTarget);

                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteScreening(IScreeningRepository repository, int id)
        {
            try
            {
                var target = await repository.DeleteScreening(id);

                Payload<ResponseScreeningDTO> payload = new Payload<ResponseScreeningDTO>();
                payload.data = Mapper.MapToDTO(target);
                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
