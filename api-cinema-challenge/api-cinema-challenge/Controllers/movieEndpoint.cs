using api_cinema_challenge.Models.MovieModels;
using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class movieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("movies");

            group.MapGet("", GetAll);
            group.MapGet("{id}", Get);
            group.MapPost("", Create);
            group.MapPut("{id}", Update);
            group.MapDelete("{id}", Delete);
            group.MapGet("{id}/screenings", GetScreenings);
            group.MapPost("{id}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAll(IRepository<Movie> repository)
        {
            IEnumerable<Movie> movies = await repository.Get();

            IEnumerable<OutputMovie> outputMovies = MovieDtoManager.Convert(movies);
            return TypedResults.Ok(outputMovies);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Get(int id, IRepository<Movie> repository)
        {
            Movie? movie = await repository.Get(id);
            if (movie == null)
                return Results.NotFound();

            OutputMovie outputMovie = MovieDtoManager.Convert(movie);
            return TypedResults.Ok(outputMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> Create(InputMovie movie, IRepository<Movie> repository)
        {
            Movie newMovie = MovieDtoManager.Convert(movie); 

            Movie result = await repository.Create(newMovie);

            OutputMovie outputMovie = MovieDtoManager.Convert(result);
            return TypedResults.Created("url", outputMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Update(int id, InputMovie inputMovie, IRepository<Movie> repository)
        {
            Movie movieToUpdate = await repository.Get(id);

            movieToUpdate.UpdatedAt = DateTime.UtcNow;
            movieToUpdate.Title = inputMovie.Title;
            movieToUpdate.Runtime = inputMovie.Runtime;
            movieToUpdate.Rating = inputMovie.Rating;
            movieToUpdate.Description = inputMovie.Description;

            Movie? result = await repository.Update(movieToUpdate);

            OutputMovie outputMovie = MovieDtoManager.Convert(result);
            return TypedResults.Ok(outputMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Delete(int id, IRepository<Movie> repository)
        {
            Movie? movie = await repository.Get(id);
            if (movie == null)
                return Results.NotFound();

            Movie result = await repository.Delete(id);

            OutputMovie outputMovie = MovieDtoManager.Convert(result);
            return TypedResults.Ok(outputMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreenings(int id, IRepository<Screening> screeningRepository)
        {
            IEnumerable<Screening> screenings = await screeningRepository.GetWhere(s => s.MovieId == id);

            IEnumerable<OutputScreening> outputScreenings = ScreeningDtoManager.Convert(screenings);
            return TypedResults.Ok(outputScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateScreening(int id, InputScreening inputScreening, IRepository<Screening> screeningRepository)
        {
            Screening newScreening = ScreeningDtoManager.Convert(inputScreening); 

            newScreening.MovieId = id;

            Screening result = await screeningRepository.Create(newScreening);

            OutputScreening outputScreening = ScreeningDtoManager.Convert(result);
            return TypedResults.Created("url", outputScreening);
        }
    }
}
