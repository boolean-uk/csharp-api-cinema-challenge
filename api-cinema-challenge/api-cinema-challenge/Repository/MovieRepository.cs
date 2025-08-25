using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository;

public class MovieRepository(CinemaDbContext cinemaDb) : IMovieRepository
{
    public async Task<IEnumerable<MovieGetDto>> GetMovies()
    {
        return await cinemaDb.Movies.Select(m=> new MovieGetDto
        {
            Id = m.Id,
            Title = m.Title,
            Rating = m.Rating,
            Description = m.Description,
            RuntimeMins = m.RuntimeMins,
            UpdatedAt = m.UpdatedAt,
            CreatedAt = m.CreatedAt
        }).ToListAsync();
    }
    
    public async Task<IEnumerable<ScreeningGetDto>> GetScreenings(int id)
    {
        var m = await cinemaDb.Movies.FirstOrDefaultAsync(m => m.Id == id);
        
        if (m == null)
        {
            throw new ArgumentException("Movie not found.");
        }
        
        return await cinemaDb.Screenings
            .Where(s => s.MovieId == id)
            .Select(s => new ScreeningGetDto
            {
                Id = s.Id,
                ScreenNumber = s.ScreenNumber,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt
            }).ToListAsync();
    }
    
    public async Task<MovieUpdateDto> UpdateMovie(int id, MovieUpdateDto mud)
    {
        var movieToUpdate = await cinemaDb.Movies.FirstOrDefaultAsync(m => m.Id == id);
        
        if (movieToUpdate == null) 
        {
            throw new ArgumentException("Movie not found.");
        }
        
        if(mud.Title != null) movieToUpdate.Title = mud.Title;
        if(mud.Rating != null) movieToUpdate.Rating = mud.Rating.Value;
        if(mud.Description != null) movieToUpdate.Description = mud.Description;
        if(mud.RuntimeMins != null) movieToUpdate.RuntimeMins = mud.RuntimeMins.Value;
        movieToUpdate.UpdatedAt = DateTime.UtcNow;
        
        await cinemaDb.SaveChangesAsync();
        
        return mud; // Should not be this object as it doesn't conform to the spec.
    }

    public async Task<MovieGetDto> DeleteMovie(int id)
    {
        var entity = await cinemaDb.Movies
            .Include(m => m.Screenings)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (entity == null)
        {
            throw new ArgumentException("Movie not found.");
        }
        
        // Should cascade... hopefully
        cinemaDb.Movies.Remove(entity);
        await cinemaDb.SaveChangesAsync();
        return new MovieGetDto
        {
            Id = entity.Id,
            Title = entity.Title,
            Rating = entity.Rating,
            Description = entity.Description,
            RuntimeMins = entity.RuntimeMins,
            UpdatedAt = entity.UpdatedAt,
            CreatedAt = entity.CreatedAt
        };
    }

    public async Task<ScreeningGetDto> CreateScreening(int movieId, ScreeningPostDto spd)
    {
        var m = await cinemaDb.Movies.FirstOrDefaultAsync(m => m.Id == movieId);
        
        if (m == null)
        {
            throw new ArgumentException("Movie not found.");
        }
        
        if (spd.ScreenNumber <= 0 || spd.Capacity <= 0 || spd.StartsAt == default)
        {
            throw new ArgumentException("Invalid screening data.");
        }
        
        var s = cinemaDb.Screenings.Add(new Screening
        {
            MovieId = movieId,
            ScreenNumber = spd.ScreenNumber,
            Capacity = spd.Capacity,
            StartsAt = spd.StartsAt,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        });
        
        await cinemaDb.SaveChangesAsync();
        
        return new ScreeningGetDto
        {
            Id = s.Entity.MovieId,
            ScreenNumber = s.Entity.ScreenNumber,
            Capacity = s.Entity.Capacity,
            StartsAt = s.Entity.StartsAt,
            CreatedAt = s.Entity.CreatedAt,
            UpdatedAt = s.Entity.UpdatedAt
        };
    }

    public async Task<MoviePostDto> PostMovie(MoviePostDto mpd)
    {
        // Validate input
        if (string.IsNullOrWhiteSpace(mpd.Title) ||
            mpd.Rating < 0 || mpd.Rating > 10 ||
            string.IsNullOrWhiteSpace(mpd.Description) ||
            mpd.RuntimeMins <= 0)
        {
            throw new ArgumentException("Invalid input data for movie.");
        }
        
        // Check if movie already exists
        var existingMovie = await cinemaDb.Movies
            .FirstOrDefaultAsync(m => m.Title == mpd.Title 
                                      && m.RuntimeMins == mpd.RuntimeMins);
        
        if (existingMovie != null)
        {
            throw new ArgumentException("Movie already exists with the same title and runtime.");
        }
        
        // Create new movie
        var m = cinemaDb.Movies.Add(new Movie
        {
            Title = mpd.Title,
            Rating = mpd.Rating,
            Description = mpd.Description,
            RuntimeMins = mpd.RuntimeMins,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        });

        foreach (var s in mpd.Screenings)
        {
            // Validate screening data
            if (s.ScreenNumber <= 0 || s.Capacity <= 0 || s.StartsAt == default)
            {
                throw new ArgumentException("Invalid screening data.");
            }

            // Create new screening
            cinemaDb.Screenings.Add(new Screening
            {
                MovieId = m.Entity.Id,
                Movie = m.Entity,
                ScreenNumber = s.ScreenNumber,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt
            });
        }
        
        await cinemaDb.SaveChangesAsync();
        return mpd; // Should not be this object as it doesn't conform to the spec.
    }
}
