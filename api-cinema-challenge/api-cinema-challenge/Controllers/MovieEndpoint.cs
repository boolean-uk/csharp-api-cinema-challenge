using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie");
            movieGroup.MapPost("/post", CreateMovie);
            movieGroup.MapGet("/get", GetMovies);
            movieGroup.MapPut("/update{Id}", UpdateMovie);
            movieGroup.MapDelete("/delete/{id}", DeleteMovie);
        }
     

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IMovieRepository movieRepository, CreateMovieDTO payload)
        {
            Movie returnMovie = new Movie
            {
                // Screenings = payload.Screenings,
                Description = payload.Description,
                Rating = payload.Rating,
                RuntimeMins = payload.RuntimeMins,
                Title = payload.Title,
                CreatedAt = payload.CreatedAt,
                UpdatedAt = payload.UpdatedAt
            };

            if (payload.Screenings != null)
            {
                foreach (var screen in payload.Screenings)
                {
                    returnMovie.Screenings.Add(new Screening
                    {
                        ScreenNumber = screen.ScreenNumber,
                        StartsAt = screen.StartsAt,
                        Capacity = screen.Capacity
                    });
                }
            }

            await movieRepository.CreateMovie(returnMovie);

            ApiResponse<CreateMovieDTO> response = new()
            {
                Data = payload,
                Status = "Success"
            };

            return TypedResults.Ok(response);
        }

        public static async Task<IResult> GetMovies(IMovieRepository movieRepository)
        {
            List<GetMovieDTO> returnMovies = new List<GetMovieDTO>();
            var movies = await movieRepository.GetMovies();

            foreach (var movie in movies)
            {
                returnMovies.Add(new GetMovieDTO
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Rating = movie.Rating,
                    Description = movie.Description,
                    RuntimeMins = movie.RuntimeMins,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt,
                });
            }


            var response = new ApiResponse<List<GetMovieDTO>>() { Data = returnMovies, Status = "Success" };
            return TypedResults.Ok(response);
        }


        public static async Task<IResult> UpdateMovie(IMovieRepository movieRepository, int id, MovieUpdateDTO payload)
        {

            var movie = await movieRepository.GetMovieById(id);
            if (movie == null)
            {
                return Results.BadRequest("Id is invalid");
            }


            movie.Title = string.IsNullOrEmpty(payload.Title) ? movie.Title : payload.Title;
            movie.Description = string.IsNullOrEmpty(payload.Description) ? movie.Description : payload.Description;
            movie.Rating = string.IsNullOrEmpty(payload.Rating) ? movie.Rating : payload.Rating;
            movie.RuntimeMins = payload.RuntimeMins ?? movie.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;
            await movieRepository.UpdateMovie(movie);

            GetMovieDTO returnMovie = new GetMovieDTO()
            {
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                Id = movie.Id,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
                RuntimeMins = movie.RuntimeMins
            };

            var response = new ApiResponse<GetMovieDTO>
            {
                Data = returnMovie,
                Status = "success"
            };
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> DeleteMovie(IMovieRepository movieRepository, int id)
        {
            Movie deleteMovie = await movieRepository.GetMovieById(id);

            GetMovieDTO movieDTO = new GetMovieDTO()
            {
                Title = deleteMovie.Title,
                Rating = deleteMovie.Rating,
                RuntimeMins = deleteMovie.RuntimeMins,
                Description = deleteMovie.Description,
                Id = deleteMovie.Id,
                UpdatedAt=deleteMovie.UpdatedAt,
                CreatedAt = deleteMovie.CreatedAt
            };

           await movieRepository.DeleteMovie(deleteMovie);

            var response = new ApiResponse<GetMovieDTO>()
            {
                Data= movieDTO,
                Status = "success"
            };

            return TypedResults.Ok(response);
        }
    }
}
