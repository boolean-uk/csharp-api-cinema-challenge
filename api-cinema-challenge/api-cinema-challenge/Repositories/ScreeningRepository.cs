using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO.ScreeningDTOs;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public interface IScreeningRepository
    {
        Task<GetScreeningDTO?> CreateScreening(int movieId, CreateScreeningDTO cDTO);
        Task<List<GetScreeningDTO>> GetScreenings(int movieId);
    }
    public class ScreeningRepository(CinemaContext db) : IScreeningRepository
    {
        private CinemaContext _db = db;

        public async Task<GetScreeningDTO?> CreateScreening(int movieId, CreateScreeningDTO cDTO)
        {
            Movie? dbMovie = await _db.Movies.Where(x => x.Id == movieId).FirstOrDefaultAsync();
            if (dbMovie == null) { return null; }
            Screening s = new()
            {
                ScreenNumber = cDTO.ScreenNumber,
                StartTime = cDTO.StartsAt,
                CreatedAt = DateTime.UtcNow,
                Capacity = cDTO.Capacity,
                MovieId = movieId,
            };
            _db.Screenings.Add(s);
            await _db.SaveChangesAsync();
            return new GetScreeningDTO()
            {
                Id = s.Id,
                ScreenNumber = s.ScreenNumber,
                StartsAt = s.StartTime,
                Capacity = s.Capacity,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
            };
        }

        public async Task<List<GetScreeningDTO>> GetScreenings(int movieId)
        {
            return await _db.Screenings.Where(x => x.MovieId == movieId).Select(x => new GetScreeningDTO
            {
                Id = x.Id,
                ScreenNumber = x.ScreenNumber,
                Capacity = x.Capacity,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                StartsAt = x.StartTime
            }).ToListAsync();
        }
    }
}
