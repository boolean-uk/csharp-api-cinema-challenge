using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            //var screenings = app.MapGroup("screening");

            app.MapGet("/movies/{id}/screenings", GetScreeningsByMovieId);

        }

        public static async Task<IResult> GetScreeningsByMovieId(IRepository<Screening> rep, IMapper mapper, int? id)
        {
            var screenings = await rep.GetAll(id);

            var response = mapper.Map<ResponseDTO<ScreeningDTO>>(screenings);

            return TypedResults.Ok(response);
        }

        //public static async Task<IResult> Create
    }
}
