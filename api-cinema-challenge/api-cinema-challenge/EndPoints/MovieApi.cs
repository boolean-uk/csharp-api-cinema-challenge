using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTOs;
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
            movies.MapPost("/create{id}", CreateMovie);
            movies.MapPut("/update{id}", UpdateMovie);
            movies.MapDelete("/delete{id}", DeleteMovie);

            movies.MapGet("/screenings", GetScreeningsByMovieId);
            movies.MapPost("/create/{id}", CreateScreening);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovies(IMovieRepository movieRepo)
        {
            var movies = await movieRepo.GetMovies();

            if (movies == null)

            {
                return TypedResults.NotFound("Could not find any movies");

            }

            var movieDto = movies.Select(c => new MovieDTO
            {

                Id = c.Id,
                Title = c.Title,
                Rating = c.Rating,
                Description = c.Description,
                RunTimeMins = c.RunTimeMins,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,

            });

            return TypedResults.Ok(movieDto);


        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IMovieRepository movieRepo, CreateMovieDTO movieDto)
        {
            if (movieDto == null)
            {

                return Results.BadRequest("Invalid data for movie");
            }


            Movie movie = new Movie

            {
                Title = movieDto.Title,
                Rating = movieDto.Rating,
                Description = movieDto.Description,
                RunTimeMins= movieDto.RunTimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };

            var createdMovie = await movieRepo.CreateMovie(movie);

            if (createdMovie == null)
            {
                return Results.BadRequest("Movie could not be created");

            }

            var responseDto = new MovieDTO
            {
                Id = createdMovie.Id,
                Title = createdMovie.Title,
                Rating = createdMovie.Rating,
                Description = createdMovie.Description,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };

            return Results.Created($"/api/movies/{createdMovie.Id}", responseDto);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IMovieRepository movieRepo, int movieId)
        {
            var movie = await movieRepo.GetMovieById(movieId);

            if (movie == null)

            { 
                return TypedResults.NotFound("Movie not found");
            
            }

            await movieRepo.DeleteMovie(movieId);
            return TypedResults.Ok(movie);


        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(IMovieRepository movieRepo, CreateMovieDTO movieDto, int movieId)
        {
           Movie  movieToUpdate = new Movie
           
           {
               Title = movieDto.Title,
               Rating = movieDto.Rating,
               Description = movieDto.Description,
               RunTimeMins = movieDto.RunTimeMins};

            var updatedMovie = await movieRepo.UpdateMovie(movieId, movieToUpdate);

            var responseDto = new MovieDTO

            {   Id = updatedMovie.Id,
                Title = updatedMovie.Title,
                Rating = updatedMovie.Rating,
                Description = updatedMovie.Description,
                RunTimeMins = updatedMovie.RunTimeMins,
                UpdatedAt = updatedMovie.UpdatedAt
            };
            return TypedResults.Ok(responseDto);

        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningsByMovieId(IMovieRepository movieRepo, int movieId)
        {
            var screenings = await movieRepo.GetScreeningsByMovieId(movieId);

            if (screenings == null)

            {
                return TypedResults.NotFound("Could not find any screenings for the given movie");

            }

            var screeningDto = screenings.Select(s => new ScreeningDTO
            {

                Id = s.Id,
                MovieId = s.MovieId,
                ScreenNumber = s.ScreenNumber,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,

            }).ToList();

            return TypedResults.Ok(screeningDto);



        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IMovieRepository movieRepo, CreateScreeningDTO screeningDto)
        {
            if (screeningDto == null)
            {

                return Results.BadRequest("Invalid data for screening");
            }


            Screening screening = new Screening

            {
                MovieId = screeningDto.MovieId,
                ScreenNumber = screeningDto.ScreenNumber,
                Capacity = screeningDto.Capacity,
                StartsAt = screeningDto.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };

            var createdScreening = await movieRepo.CreateScreenings(screening);

            if (createdScreening == null)
            {
                return Results.BadRequest("Screening could not be created");

            }

            var responseDto = new ScreeningDTO
            {
                Id = createdScreening.Id,
                MovieId = createdScreening.MovieId,
                ScreenNumber = createdScreening.ScreenNumber,
                Capacity = createdScreening.Capacity,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };

            return Results.Created($"/api/screening/{createdScreening.Id}", responseDto);

        }


    }
            


        



}




