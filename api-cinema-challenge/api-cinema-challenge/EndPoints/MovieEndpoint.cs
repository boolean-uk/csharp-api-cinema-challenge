using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieEndpoint
    {
        // Base path of the api, used for the created call...
        private static string _basepath = AppDomain.CurrentDomain.BaseDirectory;
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movie = app.MapGroup("movies");

            movie.MapPost("/", CreateMovie);
            movie.MapGet("/", GetMovies);
            movie.MapPut("/{id}", UpdateMovie);
            movie.MapDelete("/{id}", DeleteMovie);

            movie.MapPost("/{id}/screenings", CreateScreening);
            movie.MapGet("/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MovieView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Movie()
            { 
                Title = view.Title,
                Rating = view.Rating,
                Description = view.Description,
                RuntimeMins = view.RuntimeMins,
                CreatedAt = creationTime,
                UpdatedAt = creationTime
            };
            var result = await repository.Create([], model);
            var resultDTO = new MovieDTO(result);

            var payload = new Payload<MovieDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_basepath, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            var resultList = await repository.GetAll([]);
            var resultDTOs = new List<MovieDTO>();
            foreach (var result in resultList)
            {
                resultDTOs.Add(new MovieDTO(result));
            }

            var payload = new Payload<List<MovieDTO>>() { Status = "success", Data = resultDTOs };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Movie()
            {
                Id = id,
                Title = view.Title,
                Rating = view.Rating,
                Description = view.Description,
                RuntimeMins = view.RuntimeMins,
                UpdatedAt = creationTime
            };
            var result = await repository.Update([], model);
            var resultDTO = new MovieDTO(result);

            var payload = new Payload<MovieDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_basepath, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var result = await repository.Delete([], new Movie() { Id = id });
            var resultDTO = new MovieDTO(result);

            var payload = new Payload<MovieDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Ok(payload);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, int id, ScreeningView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Screening()
            { 
                MovieId = id,
                ScreenId = view.ScreenNumber,
                Capacity = view.Capacity,
                StartsAt = DateTime.Parse(view.StartsAt).ToUniversalTime(),
                CreatedAt = creationTime,
                UpdatedAt = creationTime
            };
            var result = await repository.Create(["Movie"], model);
            var resultDTO = new ScreeningDTO(result);

            var payload = new Payload<ScreeningDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_basepath, resultDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, int id)
        {
            var resultList = await repository.GetAll(["Movie"], s => s.MovieId == id);
            var resultDTOs = new List<ScreeningDTO>();
            foreach (var result in resultList)
            {
                resultDTOs.Add(new ScreeningDTO(result));
            }

            var payload = new Payload<List<ScreeningDTO>>() { Status = "success", Data = resultDTOs };
            return TypedResults.Ok(resultDTOs);
        }
    }
}