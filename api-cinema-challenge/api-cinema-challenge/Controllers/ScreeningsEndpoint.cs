using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Movies;
using api_cinema_challenge.Models.TransferModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.TransferModels.Screenings;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningsEndpoint
    {
        public static void ConfigureScreeningsEndpoint(this WebApplication app)
        {
            var screeningsGroup = app.MapGroup("screenings/");

            screeningsGroup.MapGet("/", GetScreenings);
            screeningsGroup.MapGet("/{id}", GetScreening);
            screeningsGroup.MapPost("/", PostScreening);
            screeningsGroup.MapPut("/{id}", PutScreening);
            screeningsGroup.MapDelete("/{id}", DeleteScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetScreenings(IRepository<Screening> repo)
        {
            IEnumerable<Screening> screenings = await repo.GetAll();

            IEnumerable<ScreeningDTO> screeningsOut = screenings.Select(s => new ScreeningDTO(s.ScreeningId, s.ScreenNumber, s.Capacity, s.Starts, s.CreatedAt, s.UpdatedAt));
            Payload<IEnumerable<ScreeningDTO>> payload = new Payload<IEnumerable<ScreeningDTO>>(screeningsOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetScreening(IRepository<Screening> repo, int id)
        {
            Screening? screening = await repo.Get(id);

            if (screening == null)
            {
                return TypedResults.NotFound($"No screening with ID {id} found.");
            }

            ScreeningDTO screeningOut = new ScreeningDTO(screening.ScreeningId, screening.ScreenNumber, screening.Capacity, screening.Starts, screening.CreatedAt, screening.UpdatedAt);
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>(screeningOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostScreening(IRepository<Screening> repo, ScreeningInputDTO screeningPost)
        {

            Screening inputScreening = new Screening()
            {
                ScreenNumber = screeningPost.ScreenNumber,
                Capacity = screeningPost.Capacity,
                Starts = screeningPost.Starts,
                MovieId = screeningPost.MovieId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            Screening screening = await repo.Insert(inputScreening);

            ScreeningDTO screeningOut = new ScreeningDTO(screening.ScreeningId, screening.ScreenNumber, screening.Capacity, screening.Starts, screening.CreatedAt, screening.UpdatedAt);
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>(screeningOut);
            return TypedResults.Created($"/{screeningOut.ScreeningId}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutScreening(IRepository<Screening> repo, int id, ScreeningInputDTO screeningPut)
        {
            Screening? screening = await repo.Get(id);

            if (screening == null)
            {
                return TypedResults.NotFound($"No screening with ID {id} found.");
            }

            Screening inputScreening = new Screening()
            {
                ScreeningId = id,
                ScreenNumber = screeningPut.ScreenNumber,
                Capacity = screeningPut.Capacity,
                Starts = screeningPut.Starts,
                MovieId = screeningPut.MovieId,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = DateTime.Now
            };

            screening = await repo.Update(id, inputScreening);

            ScreeningDTO screeningOut = new ScreeningDTO(screening.ScreeningId, screening.ScreenNumber, screening.Capacity, screening.Starts, screening.CreatedAt, screening.UpdatedAt);
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>(screeningOut);
            return TypedResults.Created($"/{screeningOut.ScreeningId}",payload);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteScreening(IRepository<Screening> repo, int id)
        {
            Screening? screening = await repo.Get(id);

            if (screening == null)
            {
                return TypedResults.NotFound($"No screening with ID {id} found.");
            }

            screening = await repo.Delete(id);

            ScreeningDTO screeningOut = new ScreeningDTO(screening.ScreeningId, screening.ScreenNumber, screening.Capacity, screening.Starts, screening.CreatedAt, screening.UpdatedAt);
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>(screeningOut);
            return TypedResults.Ok(payload);
        }
    }
}
