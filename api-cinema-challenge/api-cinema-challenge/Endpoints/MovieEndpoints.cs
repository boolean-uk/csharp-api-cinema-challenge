using System.Security.Cryptography.X509Certificates;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movieGroup = app.MapGroup("/movies");

            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", AddMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);
            movieGroup.MapPost("/{id}/screenings", AddScreening);
        }

        public static async Task<IResult> GetMovies(IRepository<Movie> repo, IMapper mapper)
        {
            var movies = await repo.Get();

            return Results.Ok(mapper.Map<List<Movie>>(movies));

        }

        public static async Task<IResult> AddMovie(IRepository<Movie> repo, MoviePost movie, IMapper mapper)
        {
            Movie newMovie = new Movie
            {
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            var result = await repo.Add(newMovie);
            return Results.Ok(mapper.Map<MovieDTO>(result));
        }

        public static async Task<IResult> UpdateMovie(IRepository<Movie> repo, int id, MoviePost movie, IMapper mapper)
        {
            Movie existingMovie = await repo.GetById(id);
            if (existingMovie == null)
            {
                return Results.NotFound();
            }
            existingMovie.Title = movie.Title;
            existingMovie.Rating = movie.Rating;
            existingMovie.Description = movie.Description;
            existingMovie.RuntimeMins = movie.RuntimeMins;
            existingMovie.UpdatedAt = DateTime.Now;
            var result = await repo.Update(existingMovie);
            return Results.Ok(mapper.Map<MovieDTO>(result));
        }

        public static async Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
        {
            var existingMovie = await repo.GetById(id);
            if (existingMovie == null)
            {
                return Results.NotFound();
            }
            var result = await repo.Delete(id);
            return Results.Ok(result);
        }

        public static async Task<IResult> GetScreenings(IRepository<Screening> screenRepo , int id, IMapper mapper)
        {
            List<Screening> screen  = await screenRepo.GetQuery().Where(s => s.MovieId == id).ToListAsync();


            return Results.Ok(mapper.Map<List<ScreeningDTO>>(screen));

        }

        public static async Task<IResult> AddScreening(IRepository<Screening> screenRepo, IRepository<Movie> movieRepo, ScreeningPost screening, IMapper mapper, int id)
        {
            Movie movie = await movieRepo.GetById(id);

            if(movie == null) return Results.NotFound();

            Screening newScreening = new Screening
            {
                MovieId = movie.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
           
            var result = await screenRepo.Add(newScreening);

            var screeningDto = mapper.Map<ScreeningDTO>(result);

            return Results.Ok(screeningDto);
        }


    }
}
