using api_cinema_challenge.DTO;
using api_cinema_challenge.Reposetories;

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

            return TypedResults.Ok(movieDTO);
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
                var dto = new List<MovieDTO>();
                foreach (var result in results)
                {
                    var movieDTO = new MovieDTO(result);
                    dto.Add(movieDTO);
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
                var result = new MovieDTO(movie);

                return TypedResults.Ok(result);
            }
        }

    }
}
