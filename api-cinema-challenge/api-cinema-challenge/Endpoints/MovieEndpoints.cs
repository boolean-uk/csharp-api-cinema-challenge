using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movieGroup = app.MapGroup("Movies");

            movieGroup.MapGet("", GetMovies);
            movieGroup.MapGet("/{id}", GetAMovie);
            movieGroup.MapPost("/{id}", CreateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            var movies = await repository.GetMovies();
            

            List<MovieDTO> dtoMovies = new List<MovieDTO>();

            foreach (var movie in movies)
            {
                MovieDTO movieDTO = new MovieDTO()
                {
                    Title = movie.Title,
                    Runtime = movie.Runtime,
                    Rating = movie.Rating,
                    Description = movie.Description,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt,
                    Screenings = movie.Screenings.Where(s => s.MovieId == movie.Id).Select(s => new ScreeningDTO
                    {
                        Capacity = s.Capacity,
                        ScreenNumber = s.ScreenNumber,
                        startsAt = s.startsAt,
                        CreatedAt = s.CreatedAt,
                        UpdatedAt= s.UpdatedAt

                    }).ToList()
                };
                dtoMovies.Add(movieDTO);
            };
                
            return TypedResults.Ok(dtoMovies);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAMovie(IMovieRepository movieRepository, int id)
        {
            var movie = await movieRepository.GetMovieById(id);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
                Screenings = movie.Screenings.Where(s => s.MovieId == movie.Id).Select(s => new ScreeningDTO
                {
                    Capacity = s.Capacity,
                    ScreenNumber = s.ScreenNumber,
                    startsAt = s.startsAt,
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt

                }).ToList()

            };
            return TypedResults.Ok(movieDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IMovieRepository movieRepository, Movie movie)
        {
            await movieRepository.CreateMovie(movie);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt

            };
            return TypedResults.Ok(movieDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IMovieRepository movieRepository, int id)
        {
            var movie = await movieRepository.GetMovieById(id);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            };
            await movieRepository.DeleteMovie(id);
            return TypedResults.Ok(movieDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IMovieRepository movieRepository, int id, Movie movie)
        {
            var updatedMovie = await movieRepository.UpdateMovie(id, movie);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
            };
            return TypedResults.Ok(movieDTO);
        }
    }
}
