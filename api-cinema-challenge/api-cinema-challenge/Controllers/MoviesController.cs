using api_cinema_challenge.Dtos;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movies;
        private readonly IScreeningRepository _screenings;

        public MoviesController(IMovieRepository movies, IScreeningRepository screenings)
        { _movies = movies; _screenings = screenings; }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<MovieDto>> Create(CreateMovie req)
        {
            var m = await _movies.AddAsync(new Movie { Title = req.Title, Rating = req.Rating, Description = req.Description, RuntimeMins = req.RuntimeMins });
            return CreatedAtAction(nameof(GetAll), null,
                new MovieDto(m.Id, m.Title, m.Rating, m.Description, m.RuntimeMins, m.CreatedAt, m.UpdatedAt));
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetAll()
        {
            var list = await _movies.GetAllAsync();
            return Ok(list.Select(m => new MovieDto(m.Id, m.Title, m.Rating, m.Description, m.RuntimeMins, m.CreatedAt, m.UpdatedAt)));
        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<MovieDto>> Update(int id, UpdateMovie req)
        {
            var updated = await _movies.UpdateAsync(id, new Movie { Title = req.Title, Rating = req.Rating, Description = req.Description, RuntimeMins = req.RuntimeMins });
            if (updated == null) return NotFound();
            return Ok(new MovieDto(updated.Id, updated.Title, updated.Rating, updated.Description, updated.RuntimeMins, updated.CreatedAt, updated.UpdatedAt));
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<MovieDto>> Delete(int id)
        {
            var deleted = await _movies.DeleteAsync(id);
            if (deleted == null) return NotFound();
            return Ok(new MovieDto(deleted.Id, deleted.Title, deleted.Rating, deleted.Description, deleted.RuntimeMins, deleted.CreatedAt, deleted.UpdatedAt));
        }

        [HttpPost("{id:int}/screenings")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<ScreeningDto>> CreateScreening(int id, CreateScreening req)
        {
            var startsUtc = req.StartsAt.Kind == DateTimeKind.Utc
                ? req.StartsAt
                : DateTime.SpecifyKind(req.StartsAt, DateTimeKind.Utc);

            var s = await _screenings.AddForMovieAsync(id, new Screening
            {
                ScreenNumber = req.ScreenNumber,
                Capacity = req.Capacity,
                StartsAt = startsUtc
            });

            return CreatedAtAction(nameof(GetScreenings), new { id },
                new ScreeningDto(s.Id, s.ScreenNumber, s.Capacity, s.StartsAt, s.CreatedAt, s.UpdatedAt));
        }

        [HttpGet("{id:int}/screenings")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ScreeningDto>>> GetScreenings(int id)
        {
            var list = await _screenings.GetForMovieAsync(id);
            return Ok(list.Select(s => new ScreeningDto(s.Id, s.ScreenNumber, s.Capacity, s.StartsAt, s.CreatedAt, s.UpdatedAt)));
        }
    }
}
