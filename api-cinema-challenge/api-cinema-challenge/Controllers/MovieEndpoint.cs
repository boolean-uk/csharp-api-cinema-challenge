using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Interfaces;
using api_cinema_challenge.Models.PayLoad;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Models.Puts;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapPost("", PostMovie);
            movies.MapGet("", GetAllMovies);
            //movies.MapGet("/{id}", GetAMovie);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
        }


        private static async Task<IResult> PostMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, MoviePost model)
        {
            //Checking the properties
            string status = DTOHelper.PropertyChecker<MoviePost>(model);

            if (status != "success")
            {
                return TypedResults.BadRequest(status);
            }

            //Check all the ScreeningPost properties with the DTOHelper.PropertyChecker
            foreach (var screening in model.Screenings)
            {
                var screeningDTO = DTOHelper.MapToDTO<ScreeningDTO>(screening);
                status = DTOHelper.PropertyChecker<ScreeningDTO>(screeningDTO);
                if (status != "success")
                {
                    return TypedResults.BadRequest(status);
                }
            }

            // 1. Convert the model to Movie and save it to the database
            var movieEntity = DTOHelper.MapToEntity<Movie>(model, "create", true, "Screenings");

            // 2. Insert the new entity into the database and retrieve the movie ID
            var insertedMovie = await movieRepository.Insert(movieEntity);

            // 3. Convert all the ScreeningsPost to Screenings 
            var screenings = model.Screenings.Select(screeningPost => DTOHelper.MapToEntity<Screening>(screeningPost, "create"));

            // 4. Associate the screenings with the movie. That means to set the MovieId of each Screening to the Id of the Movie and insert to DB.
            foreach (var screening in screenings)
            {
                screening.MovieId = insertedMovie.Id;
                await screeningRepository.Insert(screening);
            }

            // 6. Retrieve the Movie with a collection of Screenings with that MovieId
            insertedMovie = await movieRepository.SelectById(insertedMovie.Id); //, include => include.Screenings

            // 7. Convert each of the Screenings to a ScreeningDTO by using a for each loop so the DTOHelper can work properly
            var screeningDTOs = new List<ScreeningDTO>();
            foreach (var screening in screenings)
            {
                var screeningDTO = DTOHelper.MapToDTO<ScreeningDTO>(screening);
                screeningDTOs.Add(screeningDTO);
            }

            // 8. Convert the Movie to a MovieDTO
            var movieDTO = DTOHelper.MapToDTO<MovieDTO>(insertedMovie, true, "Screenings");

            // 9. Insert the ScreeningDTOs into the MovieDTO
            movieDTO.Screenings = screeningDTOs.ToList();

            // 10. Load  the payload to return
            var payload = new PayLoad1<MovieDTO>
            {
                data = movieDTO,
                status = DTOHelper.PropertyChecker<MovieDTO>(movieDTO)
            };

            // 11. Return the payload
            return TypedResults.Created($"/{payload.data.Id}", payload);
        }


        //Gets all movies from the database, converts them to DTOs and returns them in a payload, but do not return any Screenings
        private static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.SelectAll();
            var movieDTOs = movies.Select(movie => DTOHelper.MapToDTO<MovieDTO_Lite>(movie, true, "Screenings"));

            var payload = new PayLoad1<IEnumerable<MovieDTO_Lite>>
            {
                data = movieDTOs,
                status = movieDTOs.Any() ? "success" : "not found"
            };

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }


        private static async Task<IResult> GetAMovie(IRepository<Movie> repository, int id)
        {
            var movie = await repository.SelectById(id);
            var movieDTO = DTOHelper.MapToDTO<MovieDTO>(movie, true, "Screenings");

            var payload = new PayLoad1<MovieDTO>
            {
                data = movieDTO,
                status = movieDTO != null ? "success" : "not found"
            };

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }

        private static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MoviePut model)
        {
            // Fetch the existing movie from the repository
            var existingMovie = await repository.SelectById(id);
            if (existingMovie == null)
            {
                return TypedResults.NotFound();
            }

            // Map the fields from the model to the entity
            var updatedMovie = DTOHelper.MapToEntity<Movie>(model, "update");

            // Update only the provided fields, keeping the original values if not provided.
            if (model.Title != null)
            {
                existingMovie.Title = updatedMovie.Title;
            }
            if (model.Rating != null)
            {
                existingMovie.Rating = updatedMovie.Rating;
            }
            if (model.Description != null)
            {
                existingMovie.Description = updatedMovie.Description;
            }
            if (model.Runtime != 0)
            {
                existingMovie.Runtime = updatedMovie.Runtime;
            }

            // Update the existing movie in the repository
            var result = await repository.Update(id, existingMovie);

            // If update successful, return the updated movie
            if (result != null)
            {
                var payload = new PayLoad1<MovieDTO_Lite>
                {
                    data = DTOHelper.MapToDTO<MovieDTO_Lite>(result, true, "Screenings"),
                    status = "success"
                };
                return TypedResults.Ok(payload);
            }
            else
            {
                // If update fails, return bad request
                return TypedResults.BadRequest("Failed to update the movie.");
            }
        }

        //Delete an existing movie.When deleting a movie, all of its screenings should also be deleted.
        private static async Task<IResult> DeleteMovie(IRepository<Movie> repository, IRepository<Screening> screeningRepository, int id)
        {
            var foundMovie = await repository.SelectById(id);
            if (foundMovie == null)
            {
                return TypedResults.NotFound("The movie does not exist");
            }

            var screenings = await screeningRepository.SelectAll();
            foreach (var screening in screenings)
            {
                if (screening.MovieId == id)
                {
                    await screeningRepository.Delete(screening.Id);
                }
            }
            var deletedMovie = await repository.Delete(id);

            var payload = new PayLoad1<MovieDTO_Lite>
            {
                data = DTOHelper.MapToDTO<MovieDTO_Lite>(deletedMovie, true, "Screenings"),
                status = "success"
            };

            return TypedResults.Ok(payload);
        }
    }
}
