using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class MoviesEndpoints
    {
        public static void ConfigureMovies(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");
            movies.MapPost("/", CreateMovie);
            movies.MapGet("/", GetMovies);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
            movies.MapPost("/{id}/screenings", CreateScreening);
            movies.MapGet("/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repo, IRepository<Screening> screeningRepo, string title, string rating, string description, int runtimeMins, List<Screening>?screeningForMovie)
        {
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            IEnumerable<Movie> movies = await repo.Get();

            
            Movie movie = new Movie()
            {
                Title = title,
                Rating = rating,
                Description = description,
                RuntimeMins = runtimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                screenings = screeningForMovie!
                

            };

            

            await repo.Insert(movie);
            await repo.Save();

            MovieDTO dto = new MovieDTO()
            {
                id = movie.Id,
                title = movie.Title,
                rating = movie.Rating,
                description = movie.Description,
                runtimeMins = movie.RuntimeMins,
                createdAt = movie.CreatedAt,
                updatedAt = movie.UpdatedAt
                
                
            };

            payload.data.Add(dto);
            payload.status = "success";

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repo)
        {
            Payload<MovieDTO>payload = new Payload<MovieDTO>();
            IEnumerable<Movie> movies = await repo.Get();
            
            foreach (Movie movie in movies)
            {
                MovieDTO movieDTO = new MovieDTO()
                {
                    id = movie.Id,
                    title = movie.Title,
                    rating = movie.Rating,
                    description = movie.Description,
                    runtimeMins= movie.RuntimeMins,
                    createdAt = movie.CreatedAt,
                    updatedAt = movie.UpdatedAt
                };
                payload.data.Add(movieDTO);
            }
            payload.status = "success";
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repo, int id, string title, string rating, string description, int runtimeMins)
        {
            Payload<MovieDTO>payload = new Payload<MovieDTO>();
            Movie movie = await repo.GetById(id);
            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtimeMins;
            movie.UpdatedAt = DateTime.UtcNow;
            await repo.Update(movie);
            await repo.Save();

            MovieDTO dto = new MovieDTO()
            {
                id = movie.Id,
                title = movie.Title,
                rating = movie.Rating,
                description = movie.Description,
                runtimeMins = movie.RuntimeMins,
                createdAt = movie.CreatedAt,
                updatedAt = movie.UpdatedAt
            };

            payload.data.Add(dto);
            payload.status = "success";
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repo, IRepository<Screening>screeningrepo, int id)
        {
            Payload<MovieDTO>payload = new Payload<MovieDTO>();
            Movie movie = await repo.GetById(id);
            MovieDTO dto = new MovieDTO()
            {
                id = movie.Id,
                title = movie.Title,
                rating = movie.Rating,
                description = movie.Description,
                runtimeMins = movie.RuntimeMins,
                createdAt = movie.CreatedAt,
                updatedAt = movie.UpdatedAt
            };

            foreach(Screening sc in movie.screenings)
            {
                await screeningrepo.Delete(sc.Id);
            }
            await repo.Delete(movie.Id);
            await repo.Save();

            payload.data.Add(dto);
            payload.status = "success";

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repo, IRepository<Movie>movieRepo, int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            Payload<ScreeningDTO>payload = new Payload<ScreeningDTO>();
            Movie movie = await movieRepo.GetById(movieId);

            Screening screening = new Screening()
            {
                movieId = movie.Id,
                screenNumber = screenNumber,
                capacity = capacity,
                startsAt = startsAt,
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            };

            await repo.Insert(screening);
            await repo.Save();

            ScreeningDTO dto = new ScreeningDTO()
            {
                id = screening.Id,
                screenNumber = screening.screenNumber,
                capacity = screening.capacity,
                startsAt = screening.startsAt,
                createdAt = screening.createdAt,
                updatedAt = screening.updatedAt
                
            };

            payload.data.Add(dto);
            payload.status = "success";

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repo, int movieId)
        {
            IEnumerable<Screening> AllScreenings = await repo.Get();
            List<Screening>MovieScreenings = AllScreenings.Where(x => x.movieId == movieId).ToList();
            Payload<ScreeningDTO>payload = new Payload<ScreeningDTO>();
            
            foreach (Screening screening in MovieScreenings)
            {
                ScreeningDTO screeningDTO = new ScreeningDTO()
                {
                    id = screening.Id,
                    screenNumber = screening.screenNumber,
                    capacity = screening.capacity,
                    startsAt = screening.startsAt,
                    createdAt = screening.createdAt,
                    updatedAt = screening.updatedAt
                    
                };
                payload.data.Add(screeningDTO);
            }
            payload.status = "success";
            return TypedResults.Ok(payload);
        }

    }
}
