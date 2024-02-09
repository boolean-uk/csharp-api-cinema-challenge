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
            // Map the model to a DTO
            var movieDTO = DTOHelper.MapToDTO<MovieDTO>(model);

            // Create a payload to return
            var payload = new PayLoad1<MovieDTO>
            {
                data = movieDTO,
                status = DTOHelper.PropertyChecker<MovieDTO>(movieDTO)
            };

            //Save every new screening from the model to the database
            foreach (var screening in model.Screenings)
            {
                var screeningDTO = DTOHelper.MapToDTO<ScreeningDTO>(screening);
                var screeningPayload = new PayLoad1<ScreeningDTO>
                {
                    data = screeningDTO,
                    status = DTOHelper.PropertyChecker<ScreeningDTO>(screeningDTO)
                };

                if (screeningPayload.status == "success")
                {
                    var newScreening = await screeningRepository.Insert(DTOHelper.MapToEntity<Screening>(screening, "create"));
                    screeningPayload.data = DTOHelper.MapToDTO<ScreeningDTO>(newScreening);
                }
                else
                {
                    return TypedResults.BadRequest(screeningPayload);
                }
            }

            // Check if the DTO properties are valid
            if (payload.status == "success")
            {
                // Insert the new entity into the database
                var movie = await movieRepository.Insert(DTOHelper.MapToEntity<Movie>(model, "create"));

                //Give the entityDTO the new entity's id
                payload.data = DTOHelper.MapToDTO<MovieDTO>(movie);

                // Return the payload
                return TypedResults.Created($"/{payload.data.Id}", payload);
            }
            else
            {
                // Return the payload
                return TypedResults.BadRequest(payload);
            }
        }

        private static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.SelectAll();
            IEnumerable<MovieDTO> movieDTOs = movies.Select(c => DTOHelper.MapToDTO<MovieDTO>(c));

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
            var movieDTO = DTOHelper.MapToDTO<MovieDTO>(movie);

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
