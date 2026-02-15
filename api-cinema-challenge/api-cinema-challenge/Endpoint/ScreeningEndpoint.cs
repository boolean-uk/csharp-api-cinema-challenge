using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Model;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;
using api_cinema_challenge.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoint
{
    public static class ScreeningEndpoint
    {
        //private static CinemaContext db {  get; set; }
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");
            movieGroup.MapPost("/{id}/screenings", Create);
            movieGroup.MapGet("/{id}/screenings", Get);
            /*
            movieGroup.MapPut("/update", Update);
            movieGroup.MapDelete("/delete", Delete);*/
        }

        public static async Task<IResult> Create(IRepository<Screening> repository, int id, ScreeningPost screeningObj) 
        {
            Screening screening = new Screening()
            {
                ScreenNumber = screeningObj.ScreeningNumber,
                Capacity = screeningObj.Capacity,
                StartsAt = screeningObj.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MovieId = id
            };
            var addedScreening = await repository.Add(screening);
            ScreeningServerDto dto = new ScreeningServerDto()
            {
                Id = addedScreening.Id,
                Capacity = addedScreening.Capacity,
                StartsAt = addedScreening.StartsAt,
                CreatedAt = addedScreening.CreatedAt,
                UpdatedAt = addedScreening.UpdatedAt,
                ScreenNumber = addedScreening.ScreenNumber,
            };
            Payload<ScreeningServerDto> payload = new Payload<ScreeningServerDto>()
            {
                Status = "success",
                Data = dto
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Get(IRepository<Screening> repository, int id) 
        {
            var screenings = await repository.Get();
            var filtered = screenings.Where(x => x.MovieId == id);
            var dto = filtered.Select(m => new ScreeningServerDto()
            {
                Id = m.Id,
                Capacity = m.Capacity,
                ScreenNumber = m.ScreenNumber,
                StartsAt = m.StartsAt,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
            });

            Payload<IEnumerable<ScreeningServerDto>> payload = new Payload<IEnumerable<ScreeningServerDto>>
            {
                Status = "success",
                Data = dto
            };
            return TypedResults.Ok(payload);
        }
    }
}
