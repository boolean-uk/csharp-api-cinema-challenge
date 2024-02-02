using api_cinema_challenge.DTO;
using api_cinema_challenge.Reposetories;
using System.Globalization;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screenings");

            screeningGroup.MapPost("/", CreateScreening);
            screeningGroup.MapGet("/", GetScreenings);
            
        }

        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPayload screeningPayload)
        {
            if (screeningPayload.screenNumber <= 0 )
            {
                return TypedResults.BadRequest("screeNumber needs to be a positive integer above 0");
            }
            if (screeningPayload.capasity <= 0)
            {
                return TypedResults.BadRequest("capasity needs to be a positive integer above 0");
            }
            if (screeningPayload.startsAt == null || screeningPayload.startsAt == string.Empty)
            {
                return TypedResults.BadRequest("not a valid startsAt, starts at needs to be written in the format (dd-MM-yyyy HH:mm:ss)");
            }
            DateTime dateTime;
            string dateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss";
            if(!DateTime.TryParseExact(screeningPayload.startsAt, dateTimeFormat, null, DateTimeStyles.None, out dateTime))
            {
                return TypedResults.BadRequest("not a valid startsAt, starts at needs to be written in the format (yyyy-MM-dd HH:mm:ss)");
            }

            var result = await repository.CreateScreening(
                screeningPayload.screenNumber,
                screeningPayload.capasity,
                dateTime,
                screeningPayload.movieID
                );

            ScreeningDTO screeningDTO = new ScreeningDTO(result);

            return TypedResults.Ok(screeningDTO);
        }
        public static async Task<IResult> GetScreenings(IRepository repository)
        {
            var screenings = await repository.GetScreenings();
            if (screenings == null)
            {
                return TypedResults.NotFound("something went wrong");
            }
            else
            {
                var dto = new List<ScreeningDTO>();
                foreach (var screening in screenings)
                {
                    var screeningDTO = new ScreeningDTO(screening);
                    dto.Add(screeningDTO);
                }

                return TypedResults.Ok(dto);
            }
        }
        
       
    }
}
