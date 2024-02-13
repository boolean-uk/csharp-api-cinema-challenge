using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.User_Requests;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Payloads;
using workshop.wwwapi.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("cinema/movies");

            movieGroup.MapGet("", GetMovies);
            movieGroup.MapGet("{id}", GetMovieByID);
            movieGroup.MapPut("{id}", UpdateMovie);
            movieGroup.MapPost("", CreateMovie);
            movieGroup.MapDelete("{id}", DeleteMovie);
        }
        
        // --- Movie ---
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            Payload<IEnumerable<MovieDTO>> payload = new();

            // Create DTO
            List<MovieDTO> DTO = (await repository.GetAll())
                    .Select(movie => new MovieDTO(movie)).ToList();
            payload.data = DTO;

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovieByID(IRepository<Movie> repository, int id)
        {
            Payload<MovieDTO> payload = new();
            // Create DTO
            payload.data = new MovieDTO(repository.GetByID(id).Result);

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MovieRequest request)
        {
            Payload<MovieDTO> payload = new();
            Movie entity = new Movie(request);
            
            entity = await repository.Insert(entity);

            // Create DTO            
            payload.data = new MovieDTO(entity);

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieRequest request)
        {
            Payload<MovieDTO> payload = new();

            if (repository.GetByID(id).Result == default(Movie))
                return TypedResults.NotFound();

            Movie entity = new Movie(request)
            {
                Id = id,
                CreatedAt = repository.GetByID(id).Result.CreatedAt, 
                UpdatedAt = DateTime.UtcNow 
            };

            entity = await repository.Update(id, entity);

            // Create DTO
            payload.data = new MovieDTO(entity);

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            Payload<MovieDTO> payload = new();

            payload.data = new MovieDTO(await repository.Delete(id));

            return TypedResults.Ok(payload);
        }
    }
}