using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies/");

            movieGroup.MapPost("", CreateMovie);
            movieGroup.MapGet("", GetAllMovies);
            movieGroup.MapPut("{id}", UpdateMovie);
            movieGroup.MapDelete("{id}", DeleteMovie);
            movieGroup.MapPost("{id}/screenings", CreateScreening);
            movieGroup.MapGet("{id}/screenings", GetScreenings);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> movieRepo, PostMovie model)
        {
            var entity = new Movie() 
            { 
                Title = model.Title, 
                Rating = model.Rating, 
                Description=model.Description,
                RuntimeMins = model.RuntimeMins,
            };
            var create = await movieRepo.Create(entity);

            var result = new MovieDTO()
            {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = model.RuntimeMins
            };

            return TypedResults.Created($"{entity.Id}",result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> movieRepo)
        {
            var result = await movieRepo.GetAll();

            var response = from movie in result
                           select new MovieDTO()
                           {
                               Id = movie.Id,
                               Description = movie.Description,
                               Rating = movie.Rating,
                               RuntimeMins = movie.RuntimeMins,
                               CreatedAt = movie.CreatedAt,
                               UpdatedAt = movie.UpdatedAt,
                           };
            Payload <IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>();
            payload.data = response;
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public static async Task<IResult> UpdateMovie(IRepository<Movie> movieRepo, int id, PutMovie model)
        {
            var entity = await movieRepo.GetById(id);
            if (entity == null)
            {
                return TypedResults.NotFound();
            }
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.Rating = model.Rating;
            entity.RuntimeMins = (int)model.RuntimeMins;
            var update = new MovieDTO()
            {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = (int)model.RuntimeMins
            };
            var result = await movieRepo.Update(entity);

            return TypedResults.Created("",update);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> movieRepo, int id)
        {
            var result = await movieRepo.Delete(id);
            if (result == null)
            {
                return TypedResults.NotFound();
            }

            var delete = new MovieDTO() 
            {
                Title = result.Title,
                Rating = result.Rating,
                Description = result.Description,
                RuntimeMins = (int)result.RuntimeMins
            };
            return TypedResults.Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> screeningRepo, IRepository<Movie> movieRepo, PostScreening model, int movieId)
        {
            if(movieRepo.GetById(movieId) == null) 
            {
                return TypedResults.NotFound($"Movie with id {movieId} does not exist"); 
            }
            
            var entity = new Screening()
            {
                ScreenNumber = model.ScreenNumber,
                Capacity = model.Capacity,
                StartsAt = model.StartsAt,
                MovieId = movieId,
            };
            var create = await screeningRepo.Create(entity);

            var result = new ScreeningDTO()
            {
                Id = create.Id,
                ScreenNumber = create.ScreenNumber,
                Capacity = create.Capacity,
                StartsAt = create.StartsAt,
                CreatedAt = create.CreatedAt,
                UpdatedAt = create.UpdatedAt,
            };

            return TypedResults.Created($"{entity.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public static async Task<IResult> GetScreenings(IRepository<Movie> movieRepo, int id)
        {
            var entity = await movieRepo.GetById(id);
            if(entity == null)
            {
                return TypedResults.NotFound();
            }

            var screenings = from screening in entity.Screenings
                             select new ScreeningDTO()
                             {
                                 Id = screening.Id,
                                 ScreenNumber = screening.ScreenNumber,
                                 Capacity = screening.Capacity,
                                 StartsAt = screening.StartsAt,
                                 CreatedAt = screening.CreatedAt,
                                 UpdatedAt = screening.UpdatedAt,
                             };

            return TypedResults.Ok(screenings);

        }
    }
}

