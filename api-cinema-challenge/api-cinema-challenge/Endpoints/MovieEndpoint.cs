using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.Payload;
using api_cinema_challenge.Models.Response;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movie = app.MapGroup("/movies");
            movie.MapPost("/create", CreateMovie);
            movie.MapGet("/get", GetMovies);
            movie.MapPut("/update", UpdateMovie);
            movie.MapDelete("/delete", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie, MoviePayload> repo, MoviePayload payload)
        {
            Movie movie = await repo.Create(payload);
            MovieDTO dto = new MovieDTO()
            {
                Id = movie.Id,
                Title = movie.Title,
                RuntimeMins = movie.RuntimeMins,
                Description = movie.Description,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
            };
            Response response = new Response("success", dto);
            return TypedResults.Created("/", response);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie, MoviePayload> repo)
        {
            IEnumerable<Movie> movies = await repo.GetAll();
            IEnumerable<MovieDTO> mDTOS = movies.Select(m => new MovieDTO()
            {
                Id = m.Id,
                Title = m.Title,
                RuntimeMins = m.RuntimeMins,
                Description = m.Description,
                Rating = m.Rating,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
            });
            Response response = new Response("success", mDTOS);

            return TypedResults.Ok(response);
            
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie, MoviePayload> repo, MoviePayload payload, int id)
        {
            Movie movie = await repo.Update(payload, id );
            return movie != null
                ? TypedResults.Created("/", new Response("success", new MovieDTO()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    RuntimeMins = movie.RuntimeMins,
                    Description = movie.Description,
                    Rating = movie.Rating,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt,

                }))
                : TypedResults.NotFound(new Response("failed", "Movie not found"));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie, MoviePayload> repo, int id)
        {
            Movie movie = await repo.Delete(id);
            return movie != null
                ? TypedResults.Created("/", new Response("success", new MovieDTO()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    RuntimeMins = movie.RuntimeMins,
                    Description = movie.Description,
                    Rating = movie.Rating,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt,

                }))
                : TypedResults.NotFound(new Response("failed", "Movie not found"));
        }
    }
}