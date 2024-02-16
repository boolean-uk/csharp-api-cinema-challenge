using api_cinema_challenge.Data;
using api_cinema_challenge.Models.Base;
using api_cinema_challenge.Models.InputDTOs;
using api_cinema_challenge.Models.OutputDTOs;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            app.MapGet("/movies", GetMovies);
            app.MapGet("/movies/{id}", GetMovieById);
            app.MapPost("/movies", CreateMovie);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        private static async Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
        {
            var movie = await repo.GetById(id);
            var movieDto = MovieOutputDto.Create(movie);
            await repo.Delete(id);
            return Results.Ok(new Payload<object>().Get(movieDto));
        }

        private static async Task<IResult> UpdateMovie(IRepository<Movie> repo, int movieId, MovieInputDto inputDto)
        {

            var movie = await repo.GetById(movieId);
            movie.Id = movieId;
            movie.Title = inputDto.Title;
            movie.Description = inputDto.Description;
            movie.RuntimeMins = inputDto.RuntimeMins;
            movie.Rating = inputDto.Rating;
            movie.UpdatedAt = DateTime.UtcNow;


            var updated = await repo.Update(movie);
            return TypedResults.Accepted($"/movies/{movieId}", new Payload<object>().Get(MovieOutputDto.Create(updated)));
        }

        private static async Task<IResult> CreateMovie(IRepository<Movie> repo, IRepository<Screening> screeningRepo, MovieInputDto inputDto)
        {
            var input = new Movie
            {
                Title = inputDto.Title,
                Description = inputDto.Description,
                Rating = inputDto.Rating,
                RuntimeMins = inputDto.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            var insertedMovie = await repo.Insert(input);

            if (inputDto.Screenings!=null)
            {
                var screeningsInput = inputDto.Screenings;
                var screenings = screeningsInput.Select(s => new Screening
                {
                    ScreenNumber = s.ScreenNumber,
                    Capacity = s.Capacity,
                    StartsAt = s.StartsAt,
                    MovieId = insertedMovie.Id,
                    Movie = insertedMovie,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });
                foreach ( var screening in screenings )
                {
                    var insertedScreening = await screeningRepo.Insert(screening);
                    insertedMovie.Screenings.Add(insertedScreening);
                    
                }

                await repo.Update(insertedMovie);
            }

            return TypedResults.Created($"/customers/{insertedMovie.Id}", new Payload<object>().Get(MovieOutputDto.Create(insertedMovie)));
        }
            private static async Task<IResult> GetMovies(IRepository<Movie> repo)
        {
            var movies = await repo.Get();
            return Results.Ok(new Payload<object>().Get(movies.Select(MovieOutputDto.Create)));
        }

        private static async Task<IResult> GetMovieById(IRepository<Movie> repo, int id)
        {
            var movie = await repo.GetById(id);
            if (movie == null) return Results.NotFound();
            return Results.Ok(new Payload<object>().Get(MovieOutputDto.Create(movie)));
        }
    }

}
