using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Movies;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.Screenings;


namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetAll);
            movieGroup.MapPost("/", Create);
            movieGroup.MapPut("/{id}", Update);
            movieGroup.MapDelete("/{id}", Delete);
            movieGroup.MapGet("/{id}/screenings", GetAllScreenings);
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> repository)
        {
            var movies = await repository.GetAll();
            Payload<IEnumerable<Movie>> payload = new() { Data = movies };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> Create(IRepository<Movie> repository, IRepository<Screening> screeningRepository, MovieInput movie)
        {
            if (movie.Title == null || movie.Rating == null || movie.Description == null)
            {
                Payload<string> errorPayload = new() { Status = "error", Data = "Invalid input." };
                return TypedResults.BadRequest(errorPayload);
            }

            Movie newMovie = new() { Title = movie.Title, Rating = movie.Rating, Description = movie.Description, RuntimeMins = movie.RuntimeMins };
            await repository.Create(newMovie);

            movie.Screenings.ForEach(async screening =>
            {
                Screening newScreening = new() { MovieId = newMovie.Id, StartsAt = screening.StartsAt, ScreenNumber = screening.ScreenNumber, Capacity = screening.Capacity };
                await screeningRepository.Create(newScreening);
            }); 

            Payload<Movie> payload = new() { Data = newMovie };
            return TypedResults.Created($"/{newMovie.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Update(IRepository<Movie> repository, int id, MovieInput newData)
        {
            var movie = await repository.GetById(id);

            if (movie == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Movie not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            if (newData.Title == null || newData.Rating == null || newData.Description == null)
            {
                Payload<string> errorPayload = new() { Status = "error", Data = "Invalid input." };
                return TypedResults.BadRequest(errorPayload);
            }

            movie.Update(newData);
            await repository.Update(movie);

            Payload<Movie> payload = new() { Data = movie };
            return TypedResults.Created($"/{movie.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Delete(IRepository<Movie> repository, int id)
        {
            var movie = await repository.GetById(id);

            if (movie == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Movie not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            await repository.Delete(id);

            Payload<Movie> payload = new() { Data = movie };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllScreenings(IRepository<Screening> repository, IRepository<Movie> movieRepository, int id)
        {
            var movie = await movieRepository.GetById(id);
            if (movie == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Movie not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            var screenings = await repository.GetAll();
            Payload<IEnumerable<ScreeningDto>> payload = new() { Data = screenings.Where(s => s.MovieId == id).Select(s => s.ToDto()) };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, IRepository<Movie> movieRepository, int movieId, ScreeningInput screening)
        {
            var movie = await movieRepository.GetById(movieId);
            if (movie == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Movie not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            Screening newScreening = new() { MovieId = movieId, StartsAt = screening.StartsAt, ScreenNumber = screening.ScreenNumber, Capacity = screening.Capacity };
            await repository.Create(newScreening);

            Payload<ScreeningDto> payload = new() { Data = newScreening.ToDto() };
            return TypedResults.Created($"/{newScreening.Id}", payload);
        }
    }
}
