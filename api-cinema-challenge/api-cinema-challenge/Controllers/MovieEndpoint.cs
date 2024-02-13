using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie");

            movieGroup.MapGet("", GetMovies);
            movieGroup.MapPost("", CreateMovie);
            movieGroup.MapPut("{id}", UpdateMovie);
            movieGroup.MapDelete("", DeleteMovie);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            IEnumerable<Movie> movie = await repository.Get();
            if (movie == null) return TypedResults.NotFound();
            return TypedResults.Ok(new Payload<IEnumerable<Movie>>(movie));
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, 
            IRepository<Screening> screeningRepository, MovieDto movieDto)
        {
            if (movieDto.Description.Trim().Count() == 0 ||
                movieDto.Description.Trim().Count() == 0 ||
                movieDto.RuntimeMins <= 0) return TypedResults.BadRequest();

            Movie movie = Service.MovieService.toMovie(movieDto);
            Movie result = await repository.Create(movie);

            if( movieDto.Screenings != null)
            {
                foreach(ScreeningDto screening in movieDto.Screenings)
                {
                    if (screening.ScreenNumber == 0 ||
                        screening.Capacity < 1)
                        return TypedResults.BadRequest("Attached screening was a bad request");
                    await screeningRepository.Create(
                            Service.ScreeningService.toScreening(screening, result.Id)
                        );
                }
            }
            return TypedResults.Created($"movie/{result.Id}", new Payload<Movie>(result));
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieDto movieDto)
        {
            Movie movie = await repository.Get(id);
            if (movie == null) return TypedResults.NotFound();

            if (movieDto.Description.Trim().Count() == 0 &&
                movieDto.Description.Trim().Count() == 0 &&
                movieDto.RuntimeMins <= 0) return TypedResults.BadRequest();

            movie = Service.MovieService.updateMovie(movie, movieDto);
            Movie result = await repository.Update(movie);

            return TypedResults.Ok(new Payload<Movie>(result));
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            Movie movie = await repository.Get(id);
            if (movie == null) return TypedResults.NotFound();

            Movie result = await repository.Delete(movie);
            return TypedResults.Ok(new Payload<Movie>(result));
        }
    }
}
