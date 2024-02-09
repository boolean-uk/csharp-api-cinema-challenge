using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.PostModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using api_cinema_challenge.Models.DTO;
using System.Drawing.Printing;

namespace api_cinema_challenge.Controllers
{

    public static class ScreeningEndpoint {

        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            app.MapGet("movies/{id}/screenings", AllScreenings);
            app.MapPost("movies/{id}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AllScreenings(IRepository<Screening> screenRepository, int id)
        {
            DTO result = new DTO();
            IEnumerable<Screening> screenings = await screenRepository.GetAll();
            foreach (Screening screening in screenings)
            {
                if (screening.MovieId.Equals(id))
                {
                    result.createDtScreening(screening);
                }
            }
            PayLoad<IEnumerable<DtScreening>> payLoad = new PayLoad<IEnumerable<DtScreening>>(result.Screenings);
            return TypedResults.Ok(payLoad);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, PMScreening model, int id)
        {
            DTO result = new DTO();
            var startTime = DateTime.Parse(model.StartsAt);
            Screening screening = new Screening() {Capacity = model.Capacity, ScreenNumber = model.ScreenNumber, StartsAt= new DateTime(startTime.Year,startTime.Month,startTime.Day, startTime.Hour, startTime.Minute, startTime.Second, DateTimeKind.Utc), MovieId = id};
            result.createDtScreening(await repository.Insert(screening));

            PayLoad<DtScreening> payLoad = new PayLoad<DtScreening>(result.Screening);

            return TypedResults.Created($"/{payLoad.data}", payLoad);

        }

    }
}
