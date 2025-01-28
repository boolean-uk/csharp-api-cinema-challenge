using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Response;
using AutoMapper;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieEndPoint
    {
        public static void ConfigureMovieEndPoints(this WebApplication app)
        {
            var movie = app.MapGroup("movies");

            movie.MapGet("/", GetAllMovies);
            movie.MapPost("/", AddMovie);
            movie.MapPut("/{movie_id}", UpdateMovie);
            movie.MapDelete("/{movie_id}", DeleteMovie);

            movie.MapPost("/{movie_id}/screenings", AddScreening);
            movie.MapGet("/{movie_id}/screenings", GetAllScreenings);
        }
        public static async Task<IResult> GetAllMovies(IRepository<Movie> repository, IMapper mapper)
        {
            var movies = await repository.Get();
            var response = mapper.Map<List<MovieDTO>>(movies);

            return TypedResults.Ok(new Response<List<MovieDTO>>("Success", response));
        }
        public static async Task<IResult> AddMovie(IRepository<Movie> repository, IRepository<Screening> screeningRepository, MoviePost model, IMapper mapper)
        {
            Movie movie = new Movie()
            {
                title = model.title,
                description = model.description,
                rating = model.rating,
                runtimeMins = model.runtimeMins
            };
            
            await repository.Add(movie);
            
            if (model.screening != null && model.screening.Any())
            {
                foreach (var screenings in model.screening)
                {
                    Screening screening = new Screening
                    {
                        screenNumber = screenings.screenNumber,
                        capacity = screenings.capacity,
                        startsAt = screenings.startsAt,
                        Movie = movie,
                    };
                    await screeningRepository.Add(screening);
                }
            }

            var response = mapper.Map<MovieDTO>(movie);

            return TypedResults.Created($"https://localhost:7010/movies/{movie.Id}", new Response<MovieDTO>("Success", response));
        }
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int movie_id, MoviePut model, IMapper mapper)
        {
            var target = await repository.GetById(movie_id);
            if (target == null)
            {
                return TypedResults.NotFound("Movie not found");
            }

            if (!string.IsNullOrEmpty(model.title)) { target.title = model.title; }
            if (!string.IsNullOrEmpty(model.description)) { target.description = model.description; }
            if (!string.IsNullOrEmpty(model.rating)) { target.rating = model.rating; }
            if (model.runtimeMins != null) { target.runtimeMins = (int)model.runtimeMins; }

            target.updatedAt = DateTime.Now;

            await repository.Update(target);

            var response = mapper.Map<MovieDTO>(target);

            return TypedResults.Ok(new Response<MovieDTO>("Success", response));
        }
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int movie_id, IMapper mapper)
        {
            var target = await repository.GetById(movie_id);
            if (target == null)
            {
                return TypedResults.NotFound("Movie not found");
            }

            await repository.Delete(movie_id);

            var response = mapper.Map<MovieDTO>(target);

            return TypedResults.Ok(new Response<MovieDTO>("Success", response));
        }
        public static async Task<IResult> AddScreening(IRepository<Movie> movieRepository, 
                                                        IRepository<Screening> screeningRepository, 
                                                        int movie_id, ScreeningPost model, IMapper mapper)
        {
            var movie = await movieRepository.GetById(movie_id);
            if (movie == null)
            {
                return TypedResults.NotFound("Movie not found");
            }
            Screening screening = new Screening
            {
                screenNumber = model.screenNumber,
                capacity = model.capacity,
                startsAt = model.startsAt,
                Movie = movie,
            };
            await screeningRepository.Add(screening);

            var response = mapper.Map<ScreeningDTO>(screening);

            return TypedResults.Ok(new Response<ScreeningDTO>("Success", response));
        }
        public static async Task<IResult> GetAllScreenings(IRepository<Movie> movieRepository,
                                                        IRepository<Screening> screeningRepository,
                                                        int movie_id, IMapper mapper)
        {
            var movie = await movieRepository.GetById(movie_id);
            if (movie == null)
            {
                return TypedResults.NotFound("Movie not found");
            }
            List<Screening> screenings = screeningRepository.GetQueryable()
                .Where(s => s.movieId == movie_id)
                .ToList();

            if (screenings == null)
            {
                return TypedResults.NotFound($"No screenings found for movie with id:{movie_id}");
            }

            var response = mapper.Map<List<ScreeningDTO>>(screenings);

            return TypedResults.Ok(new Response<List<ScreeningDTO>>("Success", response));
        }
    }
}
