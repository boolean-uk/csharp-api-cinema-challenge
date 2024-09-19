using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieAPI
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");
            movies.MapGet("", GetAllMovies);
            movies.MapGet("/{id}", GetAMovie);
            movies.MapPost("", CreateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
            movies.MapPut("/{id}", UpdateMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IMovieRepository movieRepository)
        {
            try
            {
                var result = await movieRepository.GetAllMovies();

                List<GetMovieDTO> movieDTOs = new List<GetMovieDTO>();

                foreach (var movie in result)
                {
                    List<GetScreeningForMovieDTO> screenings = new List<GetScreeningForMovieDTO>();

                    foreach (var screening in movie.Screenings)
                    {
                        GetScreeningForMovieDTO screenDTO = new GetScreeningForMovieDTO()
                        {
                            Id = screening.Id,
                            ScreenNumber = screening.ScreenNumber,
                            Capacity = screening.Capacity,
                            StartsAt = screening.StartsAt,
                            CreatedAt = screening.CreatedAt,
                            UpdatedAt = screening.UpdatedAt
                        };
                        screenings.Add(screenDTO);
                    }

                    GetMovieDTO movieDTO = new GetMovieDTO()
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Rating = movie.Rating,
                        Description = movie.Description,
                        RuntimeMins = movie.RuntimeMins,
                        CreatedAt = movie.CreatedAt,
                        UpdatedAt = movie.UpdatedAt,
                        Screenings = screenings
                    };

                    movieDTOs.Add(movieDTO);



                }
                Payload<IEnumerable<GetMovieDTO>> payload = new Payload<IEnumerable<GetMovieDTO>>();
                payload.data = movieDTOs;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAMovie(IMovieRepository movieRepository, int id)
        {
            try
            {
                var result = await movieRepository.GetMovieById(id);

                List<GetScreeningForMovieDTO> screenings = new List<GetScreeningForMovieDTO>();

                foreach (var screening in result.Screenings)
                {
                    GetScreeningForMovieDTO screenDTO = new GetScreeningForMovieDTO()
                    {
                        Id = screening.Id,
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                        CreatedAt = screening.CreatedAt,
                        UpdatedAt = screening.UpdatedAt
                    };
                    screenings.Add(screenDTO);
                }

                GetMovieDTO movieDTO = new GetMovieDTO()
                {
                    Id = result.Id,
                    Title = result.Title,
                    Rating = result.Rating,
                    Description = result.Description,
                    RuntimeMins = result.RuntimeMins,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt,
                    Screenings = screenings
                };

                Payload<GetMovieDTO> payload = new Payload<GetMovieDTO>();
                payload.data = movieDTO;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception)
            {
                return TypedResults.NotFound($"Movie with id {id} not found!");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IMovieRepository movieRepository, IScreeningRepository screeningRepository, PostMovieDTO newMovie)
        {
            try
            {

                Movie movie = new Movie()
                {
                    Title = newMovie.Title,
                    Rating = newMovie.Rating,
                    Description = newMovie.Description,
                    RuntimeMins = newMovie.RuntimeMins,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                var result = await movieRepository.CreateMovie(movie);

                foreach (PostScreeningForMovieDTO screen in newMovie.Screenings)
                {
                    var newScreening = await screeningRepository.CreateScreening(new Screening()
                    {
                        ScreenNumber = screen.ScreenNumber,
                        Capacity = screen.Capacity,
                        StartsAt = screen.StartsAt,
                        MovieId = result.Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });
                }

                var createdMovie = await movieRepository.GetMovieById(result.Id);

                List<GetScreeningForMovieDTO> screenings = new List<GetScreeningForMovieDTO>();

                foreach (var screening in createdMovie.Screenings)
                {
                    GetScreeningForMovieDTO screenDTO = new GetScreeningForMovieDTO()
                    {
                        Id = screening.Id,
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                        CreatedAt = screening.CreatedAt,
                        UpdatedAt = screening.UpdatedAt
                    };
                    screenings.Add(screenDTO);
                }

                GetMovieDTO movieDTO = new GetMovieDTO()
                {
                    Id = createdMovie.Id,
                    Title = createdMovie.Title,
                    Rating = createdMovie.Rating,
                    Description = createdMovie.Description,
                    RuntimeMins = createdMovie.RuntimeMins,
                    CreatedAt = createdMovie.CreatedAt,
                    UpdatedAt = createdMovie.UpdatedAt,
                    Screenings = screenings
                };

                Payload<GetMovieDTO> payload = new Payload<GetMovieDTO>();
                payload.data = movieDTO;
                payload.status = System.Net.HttpStatusCode.OK;
                var path = $"/movies/{result.Id}";

                return TypedResults.Created(path, payload);

            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IMovieRepository movieRepository, int id)
        {
            try
            {
                await movieRepository.DeleteMovie(id);
                return TypedResults.Ok($"Movie with id {id} deleted!");
            }
            catch (Exception)
            {
                return TypedResults.NotFound($"Movie with id {id} not found!");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository movieRepository, int id, PutMovieDTO newValues)
        {
            try
            {
                var target = await movieRepository.GetMovieById(id);

                if (target == null)
                {
                    return TypedResults.NotFound($"Movie with id {id} not found!");
                }

                Movie updatedMovie = new Movie()
                {
                    Title = newValues.Title,
                    Rating = newValues.Rating,
                    Description = newValues.Description,
                    RuntimeMins = newValues.RuntimeMins
                };

                var result = await movieRepository.UpdateMovie(id, updatedMovie);

                List<GetScreeningForMovieDTO> screenings = new List<GetScreeningForMovieDTO>();

                foreach (var screening in result.Screenings)
                {
                    GetScreeningForMovieDTO screenDTO = new GetScreeningForMovieDTO()
                    {
                        Id = screening.Id,
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                        CreatedAt = screening.CreatedAt,
                        UpdatedAt = screening.UpdatedAt
                    };
                    screenings.Add(screenDTO);
                }

                GetMovieDTO movieDTO = new GetMovieDTO()
                {
                    Id = result.Id,
                    Title = result.Title,
                    Rating = result.Rating,
                    Description = result.Description,
                    RuntimeMins = result.RuntimeMins,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt,
                    Screenings = screenings
                };

                Payload<GetMovieDTO> payload = new Payload<GetMovieDTO>();
                payload.data = movieDTO;
                payload.status = System.Net.HttpStatusCode.Created;
                var path = $"/movies/updated/{result.Id}";

                return TypedResults.Created(path, payload);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
