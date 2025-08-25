using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie").RequireAuthorization();

            movieGroup.MapPost("/", AddMovie);
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapPost("/{id}/screenings", AddScreening);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddMovie(IRepository repository, MoviePost movie)
        {
            Movie entity = new Movie();
            entity.Title = movie.Title;
            entity.Rating = movie.Rating;
            entity.Description = movie.Description;
            entity.RuntimeMins = movie.RuntimeMins;
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            var results = await repository.AddMovie(entity);
            return TypedResults.Created($"https://localhost:7195/movie/{entity.Id}", new { Title = movie.Title, Rating = movie.Rating, Description = movie.Description, RuntimeMins = movie.RuntimeMins, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var results = await repository.GetMovies();
            return TypedResults.Ok(results);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, MoviePut movie)
        {
            var entity = await repository.GetMovieId(id);

            if (movie.Title != null) entity.Title = movie.Title;
            if (movie.Rating != null) entity.Rating = movie.Rating;
            if (movie.Description != null) entity.Description = movie.Description;
            if (movie.RuntimeMins != null) entity.RuntimeMins = movie.RuntimeMins;
            entity.UpdatedAt = DateTime.UtcNow;
            entity.CreatedAt = DateTime.UtcNow;

            await repository.UpdateMovie(id, entity);
            return TypedResults.Created($"https://localhost:7195/movie/{entity.Id}", new { Title = movie.Title, Rating = movie.Rating, Description = movie.Description, RuntimeMins = movie.RuntimeMins, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var results = await repository.DeleteMovie(id);
            return TypedResults.Ok(results);
        }

        // Screenings 

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddScreening(IRepository repository, ScreeningPost screening, int movieId)
        {
            Screening entity = new Screening();
            entity.ScreenNumber = screening.ScreenNumber;
            entity.Capacity = screening.Capacity;
            entity.StartsAt = screening.StartsAt;
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            var results = await repository.AddScreening(entity);
            return TypedResults.Created($"https://localhost:7195/movie/{movieId}/screenings", new { Id = entity.Id, ScreenNumber = screening.ScreenNumber, Capacity = screening.Capacity, StartsAt = screening.StartsAt, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            List<ScreeningGet> screens = new List<ScreeningGet>();
            var results = await repository.GetScreenings();
            foreach (Screening screen in results)
            {
                if (movieId == screen.MovieId)
                {
                    screens.Add(new ScreeningGet() {Id = screen.Id, ScreenNumber = screen.ScreenNumber, Capacity = screen.Capacity, StartsAt = screen.StartsAt });  
                }
            }
            return TypedResults.Ok(screens);
        }
    }
}