using api_cinema_challenge.DTOs.MovieDTOs;
using api_cinema_challenge.DTOs.ScreeningDTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapGet("/{id}", GetMovieById).RequireAuthorization();
            movies.MapGet("/", GetMovies).RequireAuthorization();
            movies.MapPost("/", AddMovie).RequireAuthorization();
            movies.MapDelete("/{id}", DeleteMovie).RequireAuthorization("Admin");
            movies.MapPut("/{id}", UpdateMovie).RequireAuthorization("Admin");

            // screening endpoints
            movies.MapGet("/{id}/screenings", GetScreeningsForMovie).RequireAuthorization();
            movies.MapPost("/{id}/screenings", AddScreeningForMovie).RequireAuthorization("Admin");
            movies.MapGet("/{movieId}/screenings/{screeningId}", GetScreeningForMovie).RequireAuthorization();

        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovieById(int id, IRepository<Movie> repository)
        {
            var targetMovie = await repository.GetById(id);
            if (targetMovie == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"Movie with id {id} not found."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var movieDto = new MovieDto
            {
                Id = targetMovie.Id,
                Title = targetMovie.Title,
                Rating = targetMovie.Rating,
                Description = targetMovie.Description,
                RuntimeMins = targetMovie.RuntimeMins,
                CreatedAt = targetMovie.CreatedAt,
                UpdatedAt = targetMovie.UpdatedAt
            };

            var response = new
            {
                status = "success",
                data = movieDto
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            var movies = await repository.GetAll();
            if (movies == null || !movies.Any())
            {
                var errorResponse = new
                {
                    status = "error",
                    message = "No movies found."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var movieDtos = movies.Select(m => new MovieDto
            {
                Id = m.Id,
                Title = m.Title,
                Rating = m.Rating,
                Description = m.Description,
                RuntimeMins = m.RuntimeMins,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt
            }).ToList();

            var response = new
            {
                status = "success",
                data = movieDtos
            };

            return TypedResults.Ok(response);

        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddMovie(IRepository<Movie> repository, [FromBody] MoviePostDto model, HttpRequest request, IValidator<MoviePostDto> validator, IRepository<Screening> screeningRepository)
        {
            if (model == null)
            {
                var errorResponse = new { status = "error", message = "Invalid movie data" };
                return TypedResults.BadRequest(errorResponse);
            }

            var validationResult = await validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                };
                return TypedResults.BadRequest(errorResponse);
            }

            var newMovie = new Movie { Title = model.Title, Rating = model.Rating, Description = model.Description, RuntimeMins = model.RuntimeMins, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            var addedMovie = await repository.Add(newMovie);

            // add optional screenings
            if (model.Screenings != null && model.Screenings.Any())
            {
                foreach (var screeningDto in model.Screenings)
                {
                    var newScreening = new Screening
                    {
                        ScreenNumber = screeningDto.ScreenNumber,
                        Capacity = screeningDto.Capacity,
                        StartsAt = screeningDto.StartsAt,
                        MovieId = addedMovie.Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };
                    await screeningRepository.Add(newScreening);
                }
            }

            var movieDto = new MovieDto { Id = addedMovie.Id, Title = addedMovie.Title, Rating = addedMovie.Rating, Description = addedMovie.Description, RuntimeMins = addedMovie.RuntimeMins, CreatedAt = addedMovie.CreatedAt, UpdatedAt = addedMovie.UpdatedAt };

            var response = new
            {
                status = "success",
                data = movieDto
            };

            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
            var location = $"{baseUrl}/movies/{addedMovie.Id}";
            return TypedResults.Created(location, response);

        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(int id, IRepository<Movie> repository, ClaimsPrincipal user)
        {
            var username = user.Identity?.Name;

            var targetMovie = await repository.GetById(id);
            if (targetMovie == null)
            {
                var errorResponse = new { status = "error", message = $"Movie with id {id} not found." };
                return TypedResults.NotFound(errorResponse);
            }
            var deletedMovie = await repository.Delete(id);

            var movieDto = new MovieDto
            {
                Id = deletedMovie.Id,
                Title = deletedMovie.Title,
                Rating = deletedMovie.Rating,
                Description = deletedMovie.Description,
                RuntimeMins = deletedMovie.RuntimeMins,
                CreatedAt = deletedMovie.CreatedAt,
                UpdatedAt = deletedMovie.UpdatedAt
            };

            var response = new
            {
                status = "success",
                deletedBy = username,
                data = movieDto
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(int id, IRepository<Movie> repository, [FromBody] MoviePutDto model, IValidator<MoviePutDto> validator, HttpRequest request, ClaimsPrincipal user)
        {
            var username = user.Identity?.Name;
            // check if the movie we want to update exists
            var existingMovie = await repository.GetById(id);
            if (existingMovie == null)
            {
                var errorResponse = new { status = "error", message = $"The movie you want to update with ID {id} does not exist" };
                return TypedResults.NotFound(errorResponse);
            }

            if (model == null)
            {
                var errorResponse = new { status = "error", message = "Invalid movie data" };
                return TypedResults.BadRequest(errorResponse);
            }

            var validationResult = await validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                };
                return TypedResults.BadRequest(errorResponse);
            }

            // check if the new title already exists for another movie
            var allMovies = await repository.GetAll();
            var duplicateTitleMovie = allMovies.FirstOrDefault(
                m => m.Title == model.Title && m.Id != id);
            if (duplicateTitleMovie != null)
            {
                var errorResponse = new { status = "error", message = $"A movie with the title '{model.Title}' already exists." };
                return TypedResults.BadRequest(errorResponse);
            }

            // update the movie
            if (!string.IsNullOrWhiteSpace(model.Title)) existingMovie.Title = model.Title;
            if (!string.IsNullOrWhiteSpace(model.Rating)) existingMovie.Rating = model.Rating;
            if (!string.IsNullOrWhiteSpace(model.Description)) existingMovie.Description = model.Description;
            if (model.RuntimeMins is not null) existingMovie.RuntimeMins = model.RuntimeMins.Value;

            // set UpdatedAt to now
            existingMovie.UpdatedAt = DateTime.UtcNow;

            var updatedMovie = await repository.Update(id, existingMovie);

            // generate respone dto
            var movieDto = new MovieDto { Id = updatedMovie.Id, Title = updatedMovie.Title, Rating = updatedMovie.Rating, Description = updatedMovie.Description, RuntimeMins = updatedMovie.RuntimeMins, CreatedAt = updatedMovie.CreatedAt, UpdatedAt = updatedMovie.UpdatedAt };

            var response = new
            {
                status = "success",
                updatedBy = username,
                data = movieDto
            };

            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
            var location = $"{baseUrl}/movies/{updatedMovie.Id}";
            return TypedResults.Created(location, response);

        }

        // screening endpoints

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningsForMovie(int id, IRepository<Screening> screeningRepository)
        {
            var screenings = await screeningRepository.GetAll();
            var filteredScreenings = screenings.Where(s => s.MovieId == id).ToList();

            if (!filteredScreenings.Any())
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"No screenings found for movie with id {id}."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var screeningDtos = filteredScreenings.Select(s => new ScreeningDto
            {
                Id = s.Id,
                ScreenNumber = s.ScreenNumber,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt
            }).ToList();

            var response = new
            {
                status = "success",
                data = screeningDtos
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddScreeningForMovie(int id, IRepository<Screening> screeningRepository, [FromBody] ScreeningPostDto model, IValidator<ScreeningPostDto> validator, HttpRequest request, ClaimsPrincipal user)
        {
            var username = user.Identity?.Name;

            if (model == null)
            {
                var errorResponse = new { status = "error", message = "Invalid screening data" };
                return TypedResults.BadRequest(errorResponse);
            }

            var validationResult = await validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                };
                return TypedResults.BadRequest(errorResponse);
            }

            var newScreening = new Screening
            {
                ScreenNumber = model.ScreenNumber,
                Capacity = model.Capacity,
                StartsAt = model.StartsAt,
                MovieId = id,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var addedScreening = await screeningRepository.Add(newScreening);

            var screeningDto = new ScreeningDto
            {
                Id = addedScreening.Id,
                ScreenNumber = addedScreening.ScreenNumber,
                Capacity = addedScreening.Capacity,
                StartsAt = addedScreening.StartsAt,
                CreatedAt = addedScreening.CreatedAt,
                UpdatedAt = addedScreening.UpdatedAt
            };

            var response = new
            {
                status = "success",
                addedBy = username,
                data = screeningDto
            };

            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
            var location = $"{baseUrl}/movies/{id}/screenings/{addedScreening.Id}";
            return TypedResults.Created(location, response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningForMovie(int movieId, int screeningId, IRepository<Screening> screeningRepository)
        {
            var screening = await screeningRepository.GetById(screeningId);
            if (screening == null || screening.MovieId != movieId)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"Screening with id {screeningId} for movie {movieId} not found."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var screeningDto = new ScreeningDto
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt
            };

            var response = new
            {
                status = "success",
                data = screeningDto
            };

            return TypedResults.Ok(response);
        }
    }
}
