using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapPost("/", CreateMovie);
            movies.MapGet("/", GetMovies);
            movies.MapGet("/{id}", GetMovieById);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateMovie(IMovieRepository movieRepository, IScreeningRepository screeningRepository, PostMovieDTO model)
        {
            try
            {
                Payload<ResponseMovieDTO> payload = new Payload<ResponseMovieDTO>();
                var newMovie = await movieRepository.CreateMovie(new Movie() { 
                    Title = model.Title, 
                    Rating = model.Rating, 
                    Description = model.Description, 
                    RuntimeMins = model.RuntimeMins, 
                    CreatedAt = DateTime.UtcNow, 
                    UpdatedAt = DateTime.UtcNow 
                });

                foreach (PostScreeningDTOMovieLess s in model.Screenings) 
                {
                    var newScreening = screeningRepository.CreateScreening(new Screening()
                    {
                        ScreenNumber = s.ScreenNumber,
                        Capacity = s.Capacity,
                        StartsAt = s.StartsAt,
                        MovieId = newMovie.Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                }

                payload.data = Mapper.MapToDTO(await movieRepository.GetMovieById(newMovie.Id));
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Created($"https://localhost:7054/movies/{payload.data.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid Movie object");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            var results = await repository.GetMovies();
            List<Movie> movies = results.ToList();
            if (movies.Count <= 0)
            {
                return TypedResults.NoContent();
            }

            Payload<List<ResponseMovieDTO>> payload = new Payload<List<ResponseMovieDTO>>();
            List<ResponseMovieDTO> responseMovies = new List<ResponseMovieDTO>();

            foreach (Movie m in movies)
            {
                responseMovies.Add(Mapper.MapToDTO(m));
            }

            payload.data = responseMovies;
            payload.status = System.Net.HttpStatusCode.OK;

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovieById(IMovieRepository repository, int id)
        {
            try
            {
                var result = await repository.GetMovieById(id);
                if (result is null)
                {
                    return TypedResults.NotFound("Movie Not Found");
                }

                Payload<ResponseMovieDTO> payload = new Payload<ResponseMovieDTO>();
                payload.data = Mapper.MapToDTO(result);
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, int id, PutMovieDTO model)
        {
            try
            {
                var target = await repository.GetMovieById(id);
                if (target is null)
                {
                    return TypedResults.NotFound("Movie Not Found");
                }

                var updatedTarget = await repository.UpdateMovie(id, new Movie() {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description,
                    RuntimeMins = model.RuntimeMins,
                    UpdatedAt = DateTime.UtcNow
                });

                Payload<ResponseMovieDTO> payload = new Payload<ResponseMovieDTO>();
                payload.data = Mapper.MapToDTO(updatedTarget);
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            try
            {
                var target = await repository.DeleteMovie(id);

                Payload<ResponseMovieDTO> payload = new Payload<ResponseMovieDTO>();
                payload.data = Mapper.MapToDTO(target);
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
