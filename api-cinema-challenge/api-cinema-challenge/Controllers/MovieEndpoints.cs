using api_cinema_challenge.DTO.DTO_Movie;
using api_cinema_challenge.DTO.DTO_Screening;
using api_cinema_challenge.Reposetories;
using System.Globalization;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoints
    {
        
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPut("/{movieId}", UpdateMovie);
            movieGroup.MapDelete("/{movieId}", DeleteMovie);
            movieGroup.MapPost("/{movieId}/screenings", CreateScreening);
            movieGroup.MapGet("/{movieId}/screenings", GetScreenings);
        }


        public static async Task<IResult> CreateMovie(IRepository repository, MoviePayload moviePayload)
        {
            if (moviePayload.title == null || moviePayload.title == string.Empty) 
            {
                return TypedResults.BadRequest("not a valid title");
            }
            if (moviePayload.rating == null || moviePayload.rating == string.Empty)
            {
                return TypedResults.BadRequest("not a valid rating");
            }
            if (moviePayload.description == null || moviePayload.description == string.Empty)
            {
                return TypedResults.BadRequest("not a valid description");
            }
            if (moviePayload.runtimeMins <= 0)
            {
                return TypedResults.BadRequest("runtimeMins needs to be a positive integer above 0");
            }

            var result = await repository.CreateMovie(
                moviePayload.title,
                moviePayload.rating, 
                moviePayload.description,
                moviePayload.runtimeMins
                );

            MovieDTO movieDTO = new MovieDTO(result);
            MovieBaseDTO baseDTO = new MovieBaseDTO(movieDTO);

            return TypedResults.Ok(baseDTO);
        }
        
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var results = await repository.GetMovies();

            if (results == null)
            {
                return TypedResults.NotFound("something went wrong");
            }
            else
            {
                var dto = new List<MovieBaseDTO>();
                foreach (var result in results)
                {
                    var movieDTO = new MovieDTO(result);
                    MovieBaseDTO baseDTO = new MovieBaseDTO(movieDTO);

                    
                    dto.Add(baseDTO);
                }

                return TypedResults.Ok(dto);
            }
        }

        private static async Task<IResult> UpdateMovie(IRepository repository, int id,  MovieUpdateData updateData)
        {
            if (id <= 0)
            {
                return TypedResults.BadRequest("id needs to be a positive integer above 0");
            }
            if (updateData.title == null || updateData.title == string.Empty)
            {
                return TypedResults.NotFound("not a valid title");
            }
            if (updateData.rating == null || updateData.rating == string.Empty)
            {
                return TypedResults.NotFound("not a valid rating");
            }
            if (updateData.description == null || updateData.description == string.Empty)
            {
                return TypedResults.NotFound("not a valid description");
            }
            if (updateData.runtimeMins <= 0)
            {
                return TypedResults.NotFound("runtimeMins needs to be a positive integer above 0");
            }

            var movie = await repository.UpdateMovie(id, updateData.title, updateData.rating, updateData.description, updateData.runtimeMins);

            if (movie == null)
            {
                return TypedResults.NotFound("id was not a valid id");
            }
            else
            {
                var result = new MovieDTO(movie);

                return TypedResults.Ok(result);
            }



        }

        private static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            if (id <= 0)
            {
                return TypedResults.BadRequest("id needs to be a positive integer above 0");
            }

            var movie = await repository.DeleteMovie(id);


            if (movie == null)
            {
                return TypedResults.NotFound("id was not a valid id");
            }
            else
            {
                var movieDTO = new MovieDTO(movie);

                MovieBaseDTO baseDTO = new MovieBaseDTO(movieDTO);

                return TypedResults.Ok(baseDTO);
            }
        }


        public static async Task<IResult> CreateScreening(IRepository repository, int id, ScreeningPayload screeningPayload)
        {
            if (id <= 0)
            {
                return TypedResults.BadRequest("id needs to be a positive integer above 0");
            }
            if (screeningPayload.screenNumber <= 0)
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
            if (!DateTime.TryParseExact(screeningPayload.startsAt, dateTimeFormat, null, DateTimeStyles.None, out dateTime))
            {
                return TypedResults.BadRequest("not a valid startsAt, starts at needs to be written in the format (yyyy-MM-dd HH:mm:ss)");
            }

            var result = await repository.CreateScreening(
                screeningPayload.screenNumber,
                screeningPayload.capasity,
                dateTime,
                id
                
                );

            if (result == null) 
            {
                return TypedResults.NotFound("id was not a valid id");

            }
            else
            {
                ScreeningDTO screeningDTO = new ScreeningDTO(result);

                ScreeningBaseDTO baseDTO = new ScreeningBaseDTO(screeningDTO);

                return TypedResults.Ok(baseDTO);
            }
            
        }

        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            if (id <= 0)
            {
                return TypedResults.BadRequest("id needs to be a positive integer above 0");
            }
            var screenings = await repository.GetScreenings(id);
            if (screenings == null)
            {
                return TypedResults.NotFound("invalid id");
            }
            else
            {
                var dto = new List<ScreeningBaseDTO>();
                foreach (var screening in screenings)
                {
                    var screeningDTO = new ScreeningDTO(screening);
                    
                    ScreeningBaseDTO baseDTO = new ScreeningBaseDTO(screeningDTO);
                    
                    dto.Add(baseDTO);

                    
                }

                return TypedResults.Ok(dto);
            }
        }

    }
}
