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
    public static class ScreeningEndpoints
    {
        public static string Path { get; private set; } = "screenings";
        public static void ConfigureScreeningsEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            app.MapGet($"{MovieEndpoints.Path}/{{movieId}}/{Path}", GetScreenings);
            app.MapPost($"{MovieEndpoints.Path}/{{movieId}}/{Path}", CreateScreening);
            group.MapGet("/{id}", GetScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreenings(
            IRepository<Screening, int> repository, 
            IRepository<Movie, int> movieRepository, 
            IMapper mapper,
            int movieId)
        {
            try
            {
                Movie movie = await movieRepository.Get(movieId);
                IEnumerable<Screening> screenings = await repository.FindAll(
                    condition: x => x.MovieId == movieId,
                    includeChains: q => q.Include(x => x.Screen)
                );
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<ScreeningView>>(screenings) });
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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreening(IRepository<Screening, int> repository, IMapper mapper, int id)
        {
            try
            {
                Screening screening = await repository.Get(id,
                    q => q.Include(x => x.Screen)
                );
                return TypedResults.Ok(mapper.Map<ScreeningView>(screening));
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
        public static async Task<IResult> CreateScreening(
            IRepository<Screening, int> repository,
            IRepository<Movie, int> movieRepository,
            IRepository<Screen, int> screenRepository,
            IMapper mapper,
            int movieId,
            ScreeningMoviePost entity)
        {
            try
            {

                //DateTime startingAt;
                //string[] formats = { "yyyy-MM-dd HH:mm:ss", "dd-MM-yyyy HH:mm:ss" };
                //if (!DateTime.TryParseExact(entity.StartingAt, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out startingAt)) 
                //    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = $"The starting at date needs to be in one of the following formats: {string.Join(", ", formats)}" } });
                //Movie movie = await movieRepository.Get(movieId);
                //Screen screen = await screenRepository.Get(entity.ScreenId);
                //Screening screening = await repository.Add(new Screening
                //{
                //    MovieId = movie.Id,
                //    ScreenId = screen.Id,
                //    Screen = screen,
                //    StartingAt = startingAt.ToUniversalTime()
                //});

                try
                {
                    Screening screening = await CreateScreeningObject(
                        movieRepository,
                        screenRepository,
                        mapper,
                        movieId,
                        entity
                    );
                    screening = await repository.Add(screening);
                    return TypedResults.Created($"{Path}/{screening.Id}", new Payload
                    {
                        Data = mapper.Map<ScreeningView>(screening)
                    });
                } catch (ArgumentException ex)
                {
                    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { ex.Message } });
                }
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

        public static async Task<Screening> CreateScreeningObject(
            IRepository<Movie, int> movieRepository,
            IRepository<Screen, int> screenRepository,
            IMapper mapper,
            int movieId,
            ScreeningMoviePost entity)
        {
            DateTime startingAt;
            string[] formats = { "yyyy-MM-dd HH:mm:ss", "dd-MM-yyyy HH:mm:ss" };
            if (!DateTime.TryParseExact(entity.StartingAt, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out startingAt))
                throw new ArgumentException($"The starting at date needs to be in one of the following formats: {string.Join(", ", formats)}");
            Movie movie = await movieRepository.Get(movieId);
            Screen screen = await screenRepository.Get(entity.ScreenId);
            Screening screening = new Screening
            {
                MovieId = movie.Id,
                ScreenId = screen.Id,
                Screen = screen,
                StartingAt = startingAt.ToUniversalTime()
            };
            return screening;
        }
    }
}
