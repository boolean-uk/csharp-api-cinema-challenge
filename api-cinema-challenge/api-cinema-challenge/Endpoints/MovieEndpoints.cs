using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.NewFolder;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var surgeryGroup = app.MapGroup("movies");

            surgeryGroup.MapGet("/", GetMovies);
            surgeryGroup.MapPost("/", PostMovie);
            surgeryGroup.MapPut("/{id}", PutMovie);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>();
            List<MovieDTO> movieDTOs = new List<MovieDTO>();

            var movies = await repository.GetMovies();
            foreach (var movie in movies)
            {
                movieDTOs.Add(CreateMovieDTO(movie));
            }
            payload.data = movieDTOs;
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PostMovie(IRepository repository, MovieInputDTO input)
        {
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = CreateMovieDTO( await repository.CreateMovie(input));
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PutMovie(IRepository repository, MovieInputDTO input, int id)
        {
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = CreateMovieDTO(await repository.UpdateMovie(input,id));
            return TypedResults.Ok(payload);
        }

        public static MovieDTO CreateMovieDTO (Movie movie)
        {
            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
                Runtime = movie.Runtime
            };
        }
    }
}
