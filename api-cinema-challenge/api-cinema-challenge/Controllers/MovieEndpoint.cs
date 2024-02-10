using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.PayLoad;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapPost("", PostMovie);
            movies.MapGet("", GetAllMovies);
            movies.MapGet("/{id}", GetAMovie);
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

            // 4. Associate the screenings with the movie. That means to set the MovieId of each Screening to the Id of the Movie. It has to eagerly be done 
            foreach (var screening in screenings)
            {
                screening.MovieId = insertedMovie.Id;
                await screeningRepository.Insert(screening);
            }



            // 5. Insert the new entities into the database
            //

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

        /*{
            // Convert ScreeningPost to Screening and save them to DB
            var screenings = model.Screenings.Select(screeningPost => DTOHelper.MapToEntity<Screening>(screeningPost, "create"));
            await screeningRepository.InsertRange(screenings);

            // Convert MoviePost to Movie
            var movieEntity = DTOHelper.MapToEntity<Movie>(model, "create");

            // Associate the screenings with the movie
            foreach (var screening in screenings)
            {
                movieEntity.Screenings.Add(screening);
            }

            // Insert the new entity into the database
            var insertedMovie = await movieRepository.Insert(movieEntity);

            // Retrieve the Movie with a collection of Screenings with that MovieId
            insertedMovie = await movieRepository.SelectById(insertedMovie.Id); //, include => include.Screenings

            // Convert the Movie with Screenings inside to MovieDTO with ScreeningsDTO inside
            var movieDTO = DTOHelper.MapToDTO<MovieDTO>(insertedMovie);

            // Create a payload to return
            var payload = new PayLoad1<MovieDTO>
            {
                data = movieDTO,
                status = DTOHelper.PropertyChecker<MovieDTO>(movieDTO)
            };

            // Check if the DTO properties are valid
            if (payload.status == "success")
            {
                // Return the payload
                return TypedResults.Created($"/{payload.data.Id}", payload);
            }
            else
            {
                // Return the payload
                return TypedResults.BadRequest(payload);
            }
        }
        */

        //Gets all movies from the database, converts them to DTOs and returns them in a payload, but do not return any Screenings
        private static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.SelectAll();
            var movieDTOs = movies.Select(movie => DTOHelper.MapToDTO<MovieDTO>(movie, true, "Screenings"));

            var payload = new PayLoad1<IEnumerable<MovieDTO>>
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

        private static async Task<IResult> UpdateMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> DeleteMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
