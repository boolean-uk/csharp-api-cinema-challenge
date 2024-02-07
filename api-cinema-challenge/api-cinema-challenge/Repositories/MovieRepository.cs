using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO.MovieDTOs;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<GetMovieDTO> CreateMovie(CreateMovieDTO cDTO);
        Task<List<GetMovieDTO>> GetAllMovies();
        Task<GetMovieDTO?> UpdateMovie(int id, UpdateMovieDTO uDTO);
        Task<GetMovieDTO?> DeleteMovie(int id);
    }
    public class MovieRepository(CinemaContext db) : IMovieRepository
    {
        private CinemaContext _db = db;
        public async Task<GetMovieDTO> CreateMovie(CreateMovieDTO cDTO)
        {
            Movie movie = new()
            {
                Description = cDTO.Description,
                Runtime = cDTO.RuntimeMins,
                Title = cDTO.Title,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Rating = cDTO.Rating,
            };
            _db.Movies.Add(movie);
            //Create new screenings if present
            cDTO.Screenings.ForEach(x =>
            {
                Screening s = new Screening()
                {
                    MovieId = movie.Id,
                    Capacity = x.Capacity,
                    ScreenNumber = x.ScreenNumber,
                    StartTime = x.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                _db.Screenings.Add(s);
            });
            await _db.SaveChangesAsync();
            return new GetMovieDTO()
            {
                Id = movie.Id,
                Description = movie.Description,
                Rating = movie.Rating,
                CreatedAt = movie.CreatedAt,
                RuntimeMins = movie.Runtime,
                Title = movie.Title,
                UpdatedAt = movie.UpdatedAt
            };
        }

        public async Task<List<GetMovieDTO>> GetAllMovies()
        {
            return await _db.Movies.Select(x => new GetMovieDTO()
            {
                Id = x.Id,
                Description = x.Description,
                CreatedAt = x.CreatedAt,
                Rating = x.Rating,
                RuntimeMins = x.Runtime,
                Title = x.Title,
                UpdatedAt = x.UpdatedAt
            }).ToListAsync();
        }

        public async Task<GetMovieDTO?> UpdateMovie(int id, UpdateMovieDTO uDTO)
        {
            Movie? dbMovie = await _db.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbMovie == null) { return null; }
            dbMovie.Title = uDTO.Title;
            dbMovie.Rating = uDTO.Rating;
            dbMovie.Runtime = uDTO.RuntimeMins;
            dbMovie.Description = uDTO.Description;
            dbMovie.UpdatedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();
            return new GetMovieDTO()
            {
                Id = dbMovie.Id,
                Description = dbMovie.Description,
                CreatedAt = dbMovie.CreatedAt,
                Rating = dbMovie.Rating,
                RuntimeMins = dbMovie.Runtime,
                Title = dbMovie.Title,
                UpdatedAt = dbMovie.UpdatedAt
            };
        }

        public async Task<GetMovieDTO?> DeleteMovie(int id)
        {
            Movie? dbMovie = await _db.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbMovie == null) { return null; }
            _db.Movies.Remove(dbMovie);
            await _db.SaveChangesAsync();
            return new GetMovieDTO()
            {
                Id = dbMovie.Id,
                Description = dbMovie.Description,
                CreatedAt = dbMovie.CreatedAt,
                Rating = dbMovie.Rating,
                RuntimeMins = dbMovie.Runtime,
                Title = dbMovie.Title,
                UpdatedAt = dbMovie.UpdatedAt
            };
        }
    }
}
