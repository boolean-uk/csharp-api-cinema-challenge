using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTOS;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movies = app.MapGroup("movies");
            movies.MapGet("/movies", GetMovies);
            movies.MapPost("/movies/{id}", CreateMovie);
            movies.MapPut("/movies{id}", UpdateMovie);
            movies.MapDelete("/movies{id}", DeleteMovie);

            movies.MapGet("/screenings", GetScreenings);
            movies.MapPost("/screenings/{id}", CreateScreening);
        }


    }
}
