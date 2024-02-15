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
        }

        private static async Task<IResult> CreateMovie(IRepository<Movie> repo, IRepository<Screening> screeningRepo, MovieInputDto inputDto)
        {
            var input = new Movie
            {
                Title = inputDto.Title,
                Description = inputDto.Description,
                Rating = inputDto.Rating,
                RuntimeMins = inputDto.RuntimeMins,
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
                    
                });
                foreach ( var screening in screenings )
                {
                    var insertedScreening = await screeningRepo.Insert(screening);
                    insertedMovie.Screenings.Add(insertedScreening);
                    
                }

                await repo.Update(insertedMovie);
            }

            return TypedResults.Created($"/customers/{insertedMovie.Id}", MovieOutputDto.Create(insertedMovie));
        }
            private static async Task<IResult> GetMovies(IRepository<Movie> repo)
        {
            var movies = await repo.Get();
            return Results.Ok(movies.Select(MovieOutputDto.Create));
        }

        private static async Task<IResult> GetMovieById(IRepository<Movie> repo, int id)
        {
            var movie = await repo.GetById(id);
            if (movie == null) return Results.NotFound();
            return Results.Ok(MovieOutputDto.Create(movie));
        }
    }

}
