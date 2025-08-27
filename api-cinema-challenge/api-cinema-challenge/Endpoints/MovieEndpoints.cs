using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public static class MovieEndpoints
{
    public static void MapMovieEndpoints(this WebApplication app)
    {
        app.MapGet("/movies", [Authorize] async ([FromServices] IMovieRepository repo) =>
        {
            var movies = await repo.GetAllAsync();
            return Results.Ok(movies);
        })
        .WithTags("Movies");

        app.MapGet("/movies/{id}", [Authorize] async (int id, [FromServices] IMovieRepository repo) =>
        {
            var movie = await repo.GetByIdAsync(id);
            return movie is not null ? Results.Ok(movie) : Results.NotFound();
        })
        .WithTags("Movies");

        app.MapPost("/movies", [Authorize] async (Movie movie, [FromServices] IMovieRepository repo) =>
        {
            var createdMovie = await repo.CreateAsync(movie);
            return Results.Created($"/movies/{createdMovie.Id}", createdMovie);
        })
        .WithTags("Movies");

        app.MapPut("/movies/{id}", [Authorize] async (int id, Movie movie, [FromServices] IMovieRepository repo) =>
        {
            var updatedMovie = await repo.UpdateAsync(id, movie);
            return updatedMovie is not null ? Results.Ok(updatedMovie) : Results.NotFound();
        })
        .WithTags("Movies");

        app.MapDelete("/movies/{id}", [Authorize] async (int id, [FromServices] IMovieRepository repo) =>
        {
            var deleted = await repo.DeleteAsync(id);
            return deleted ? Results.Ok() : Results.NotFound();
        })
        .WithTags("Movies");
    }
}
