using api_cinema_challenge.DOTs.MovieDTOs;
using api_cinema_challenge.DOTs.ScreeningDTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieAPI
    {
        public static void ConfigueMovie(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
            movieGroup.MapGet("{id}/screenings", GetScreeningsForMovie);
            
        }

        private static async Task<IResult> GetMovies(IGenericRepository<Movie> repository)
        {
            var response = await repository.GetWithIncludes(m => m.Include(s => s.Screenings)
                                                                  .ThenInclude(t => t.Tickets)
                                                                  .ThenInclude(c => c.Customer));
            var result = response.Select(m => new MovieGet(m));
            return TypedResults.Ok(result);
        }

        [Authorize(Roles = "Admin")]
        private static async Task<IResult> CreateMovie(IGenericRepository<Movie> repository, MoviePost movie)
        {
            Movie newMovie = new Movie(movie);
            var response = await repository.Create(newMovie);
            return TypedResults.Created("", new MovieGet(response));
        }

        [Authorize(Roles = "Admin")]
        private static async Task<IResult> UpdateMovie(IGenericRepository<Movie> repository, int id, MoviePut model)
        {
            Movie entity = await repository.GetByIdWithIncludes(m => m.Where(i => i.Id == id)
                                                                  .Include(s => s.Screenings)
                                                                  .ThenInclude(t => t.Tickets)
                                                                  .ThenInclude(c => c.Customer)
                                                                  .FirstOrDefaultAsync().Result);
            if (model.Title is not null) entity.Title = model.Title;
            if (model.Rating is not null ) entity.Rating = model.Rating;
            if( model.Description is not null ) entity.Description = model.Description;
            if (model.RunTimeMins is not null ) entity.RunTimeMins = (int)model.RunTimeMins;
            entity.UpdatedAt = DateTime.UtcNow;
            var response = await repository.Update(entity);
            return TypedResults.Created("", new MovieGet(response));
        }

        [Authorize(Roles = "Admin")]
        private static async Task<IResult> DeleteMovie(IGenericRepository<Movie> repository, int id)
        {
            Movie entity = await repository.GetByIdWithIncludes(q => q.Where(i => i.Id == id).FirstOrDefaultAsync().Result);
            repository.Delete(entity);
            return TypedResults.Ok(entity);
        }

        [Authorize(Roles = "Admin")]
        private static async Task<IResult> CreateScreening(IGenericRepository<Screening> repository, int movieId, ScreeningPost model)
        {
            Screening entity = new Screening(model);
            entity.MovieId = movieId;
            var response = await repository.Create(entity);
            return TypedResults.Created("", new ScreeningGet(response));
        }
        [Authorize(Roles = "User")]
        private static async Task<IResult> GetScreeningsForMovie(IGenericRepository<Screening> repository, int movieId)
        {
            var response = await repository.GetWithIncludes(s => s.Where(i => i.MovieId == movieId));
            var result = response.Select(s => new ScreeningGet(s));
            return TypedResults.Ok(result);
        }
    }
}
