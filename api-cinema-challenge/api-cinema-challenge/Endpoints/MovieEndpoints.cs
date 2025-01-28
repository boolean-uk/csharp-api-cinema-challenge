using System.Globalization;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static string Path { get; private set; } = "movies";
        public static void ConfigureMoviesEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetMovies);
            group.MapPost("/", CreateMovie);
            group.MapGet("/{id}", GetMovie);
            group.MapPut("/{id}", UpdateMovie);
            group.MapDelete("/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetMovies(IRepository<Movie, int> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Movie> movies = await repository.GetAll();
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<MovieView>>(movies) });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetMovie(IRepository<Movie, int> repository, IMapper mapper, int id)
        {
            try
            {
                Movie movie = await repository.Get(id);
                return TypedResults.Ok(mapper.Map<MovieView>(movie));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateMovie(
            IRepository<Movie, int> repository,
            IRepository<Screening, int> screeningRepository,
            IRepository<Screen, int> screenRepository,
            IMapper mapper,
            MoviePost entity)
        {
            try
            {
                DateTime releaseDate;
                string[] formats = { "yyyy-MM-dd", "dd-MM-yyyy" };
                if (!DateTime.TryParseExact(entity.ReleaseDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate)) 
                    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = $"The release date needs to be in one of the following formats: {string.Join(", ", formats)}" } });

                Movie movie = await repository.Add(new Movie
                {
                    Title = entity.Title,
                    Rating = entity.Rating,
                    Description = entity.Description,
                    Runtime = entity.Runtime,
                    ReleaseDate = releaseDate.ToUniversalTime()
                });

                //var tasks = entity.Screenings.Select(async screening =>
                //{
                //    return await ScreeningEndpoints.CreateScreening(screeningRepository, repository, screenRepository, mapper, movie.Id, new ScreeningMoviePost(
                //        screening.ScreenId,
                //        screening.StartingAt
                //    ));
                //});

                List<IResult> results = [];
                // In the future these results should be logged, and the returned payload might contain information from them.
                // Maybe even start using a "partial_success" payload, with both the movie data and information about fail / success for the screenings.
                foreach (var screening in entity.Screenings)
                {
                    IResult r = await ScreeningEndpoints.CreateScreening(screeningRepository, repository, screenRepository, mapper, movie.Id, new ScreeningMoviePost(
                        screening.ScreenId,
                        screening.StartingAt
                    ));
                    results.Add(r);
                }


                return TypedResults.Created($"{Path}/{movie.Id}", new Payload
                {
                    Data = mapper.Map<MovieView>(movie)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> UpdateMovie(
            IRepository<Movie, int> repository,
            IRepository<Movie, int> movieRepository,
            IMapper mapper,
            int id,
            MoviePut entity)
        {
            try
            {
                Movie movie = await repository.Get(id);
                if (entity.Title != null) movie.Title = entity.Title;
                if (entity.Description != null) movie.Description = entity.Description;
                if (entity.Rating != null) movie.Rating = entity.Rating;
                if (entity.Runtime.HasValue) movie.Runtime = entity.Runtime.Value;
                if (entity.ReleaseDate != null)
                {
                    DateTime releaseDate;
                    string[] formats = { "yyyy-MM-dd", "dd-MM-yyyy" };
                    if (!DateTime.TryParseExact(entity.ReleaseDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate))
                        return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = $"The release date needs to be in one of the following formats: {string.Join(", ", formats)}" } });
                    movie.ReleaseDate = releaseDate.ToUniversalTime();
                }


                movie = await movieRepository.Update(movie);
                return TypedResults.Created($"{Path}/{movie.Id}", new Payload
                {
                    Data = mapper.Map<MovieView>(movie)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteMovie(
            IRepository<Movie, int> repository,
            IRepository<Movie, int> movieRepository,
            IMapper mapper,
            int id)
        {
            try
            {
                Movie movie = await movieRepository.Delete(id);
                return TypedResults.Created($"{Path}/{movie.Id}", new Payload { Data = mapper.Map<MovieView>(movie) });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
