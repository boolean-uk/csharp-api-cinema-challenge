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
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", PostMovie);
            movieGroup.MapPut("/{id}", PutMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapGet("/{id}/screening", GetScreenings);
            movieGroup.MapPost("/{id}/screening", PostScreening);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
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
        public static async Task<IResult> PostMovie(IMovieRepository repository, MovieInputDTO input)
        {
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = CreateMovieDTO( await repository.CreateMovie(input));
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PutMovie(IMovieRepository repository, MovieInputDTO input, int id)
        {
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = CreateMovieDTO(await repository.UpdateMovie(input,id));
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = CreateMovieDTO(await repository.DeleteMovie(id));
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IMovieRepository repository, int movieId)
        {
            Payload<IEnumerable<ScreeningDTO>> payload = new Payload<IEnumerable<ScreeningDTO>>();
            List<ScreeningDTO> screeningDTOs = new List<ScreeningDTO>();

            var screenings = await repository.GetSCreenings(movieId);
            foreach (var screening in screenings)
            {
                screeningDTOs.Add(CreateScreeningDTO(screening));
            }
            payload.data = screeningDTOs;
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PostScreening(IMovieRepository repository, int movieId ,ScreeningInputDTO input)
        {
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
            payload.data = CreateScreeningDTO(await repository.CreateScreening(input,movieId));
            return TypedResults.Ok(payload);
        }

        public static MovieDTO CreateMovieDTO (Movie movie)
        {
            List<ScreeningInputDTO> screenings = new List<ScreeningInputDTO>();
            foreach (var screening in movie.Screenings)
            {
                ScreeningInputDTO s = new ScreeningInputDTO();
                s.StartsAt = screening.StartsAt;
                s.Capacity = screening.Capacity;
                s.ScreenNumber = screening.ScreenNumber;
                screenings.Add(s);
            }
            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
                Runtime = movie.Runtime,
                //Screenings = screenings
            };
        }
        public static ScreeningDTO CreateScreeningDTO(Screening screening)
        {
            return new ScreeningDTO
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                MovieId = screening.MovieId,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt,
                StartsAt = screening.StartsAt,
                Capacity = screening.Capacity
            };
        }
    }
}
