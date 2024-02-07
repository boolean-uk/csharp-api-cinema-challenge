using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;

namespace workshop.wwwapi.Endpoints
{
    public class MoviePayload
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Director { get; set; }
        public string? Rating { get; set; }
        public DateTime? Runtime { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public bool AllFieldsFilled()
        {
            if (string.IsNullOrEmpty(Title)) { return false; }
            if (string.IsNullOrEmpty(Description)) { return false; }
            if (string.IsNullOrEmpty(Director)) { return false; }
            if (string.IsNullOrEmpty(Rating)) { return false; }
            if (!Runtime.HasValue) { return false; }
            if (!ReleaseDate.HasValue) { return false; }

            return true;
        }
    }
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetAllMovies);
            movieGroup.MapPost("/", CreateAMovie);
            movieGroup.MapPut("/{id}", UpdateMovieById);
            movieGroup.MapDelete("/{id}", DeleteMovieById);
        }

        public static async Task<IResult> GetAllMovies(IMovieRepository repository)
        {
            var movies = await repository.GetAll();
            return Results.Ok(MovieDTO.FromListOfMovies(movies));
        }

        public static async Task<IResult> GetMovieById(int id, IMovieRepository repository)
        {
            var movie = await repository.GetMovieById(id);
            if (movie == null) return Results.NotFound();
            return Results.Ok(MovieDTO.FromMovie(movie));
        }

        public static async Task<IResult> CreateAMovie(MoviePayload payload, IMovieRepository repository)
        {
            if (!payload.AllFieldsFilled()) return Results.BadRequest("All fields are required.");

            var newMovie = new Movie
            {
                Title = payload.Title,
                Description = payload.Description,
                Rating = payload.Rating,
                Director = payload.Director,
                Runtime = payload.Runtime.Value,
                ReleaseDate = payload.ReleaseDate.Value,

                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var createdMovie = await repository.CreateAMovie(newMovie);
            return Results.Created($"/movies/{createdMovie.Id}", MovieDTO.FromMovie(createdMovie));
        }

        public static async Task<IResult> UpdateMovieById(int id, MoviePayload payload, IMovieRepository repository)
        {
            if (!payload.AllFieldsFilled()) return Results.BadRequest("All fields are required.");

            var updatedMovie = await repository.UpdateAMovie(id, payload.Title, payload.Description, payload.Rating, payload.Director, payload.Runtime.Value, payload.ReleaseDate.Value);

            if (updatedMovie == null) return Results.NotFound();
            return Results.Ok(MovieDTO.FromMovie(updatedMovie));
        }

        public static async Task<IResult> DeleteMovieById(int id, IMovieRepository repository)
        {
            var deletedMovie = await repository.DeleteAMovie(id);
            if (deletedMovie == null) return Results.NotFound();

            return Results.Ok(MovieDTO.FromMovie(deletedMovie));
        }
    }
}