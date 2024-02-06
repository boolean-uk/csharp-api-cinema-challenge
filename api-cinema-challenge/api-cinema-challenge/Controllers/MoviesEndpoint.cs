using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Customer;
using api_cinema_challenge.Models.TransferModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.TransferModels.Movies;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.Controllers
{
    public static class MoviesEndpoint
    {
        public static void ConfigureMoviesEndpoint(this WebApplication app)
        {
            var moviesGroup = app.MapGroup("movies/");

            moviesGroup.MapGet("/", GetMovies);
            moviesGroup.MapGet("/{id}", GetMovie);
            moviesGroup.MapPost("/", PostMovie);
            moviesGroup.MapPut("/{id}", PutMovie);
            moviesGroup.MapDelete("/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetMovies(IRepository<Movie> repo)
        {
            IEnumerable<Movie> movies = await repo.GetAll();

            IEnumerable<MovieDTO> moviesOut = movies.Select(m => new MovieDTO(m.MovieId, m.Title, m.Rating, m.Description, m.RuntimeMinutes, m.CreatedAt, m.UpdatedAt));
            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>(moviesOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetMovie(IRepository<Movie> repo, int id)
        {
            Movie? movie = await repo.Get(id);

            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with ID {id} found.");
            }

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> PostMovie(IRepository<Movie> repo, MovieInputDTO moviePost)
        {

            Movie inputMovie = new Movie()
            {
                Title = moviePost.Title,
                Rating = moviePost.Rating,
                Description = moviePost.Description,
                RuntimeMinutes = moviePost.RuntimeMinutes,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            Movie movie = await repo.Insert(inputMovie);

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutMovie(IRepository<Movie> repo, int id, MovieInputDTO moviePut)
        {
            Movie? movie = await repo.Get(id);

            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with ID {id} found.");
            }

            Movie inputMovie = new Movie()
            {
                Title = moviePut.Title ?? movie.Title,
                Rating = moviePut.Rating ?? movie.Rating,
                Description = moviePut.Description ?? movie.Description,
                RuntimeMinutes = moviePut.RuntimeMinutes,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = DateTime.Now
            };

            movie = await repo.Update(id, inputMovie);

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Ok(payload);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
        {
            Movie? movie = await repo.Get(id);

            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with ID {id} found.");
            }

            movie = await repo.Delete(id);

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Ok(payload);
        }
    }
}
