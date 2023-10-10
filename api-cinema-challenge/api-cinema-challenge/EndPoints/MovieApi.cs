﻿using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapPost("/movies", CreateMovie);
            app.MapGet("/movies", GetMovies);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        /// <summary>Create a movie</summary>
        /// <returns>
        /// Status 201 - Movie object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovie(MoviePost m, IMovieRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Get all movies</summary>
        /// <returns>
        /// Status 200 - List of all movies
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(IMovieRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Update a movie</summary>
        /// <returns>
        /// Status 201 - Movie object updated
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static Task UpdateMovie(int id, MoviePut m, IMovieRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Delete a movie</summary>
        /// <returns>
        /// Status 200 - Movie object deleted
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static Task DeleteMovie(int id, IMovieRepository service)
        {
            throw new NotImplementedException();
        }

    }
}
