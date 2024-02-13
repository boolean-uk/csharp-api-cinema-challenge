using api_cinema_challenge.Models.DatabaseModels;
using api_cinema_challenge.Models.Dto;
using api_cinema_challenge.Models.GenericDto;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {

            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("", GetMovies);
            movieGroup.MapPost("", CreateMovie);
            movieGroup.MapPut("{id}", UpdateMovie);
            movieGroup.MapDelete("{id}", DeleteMovie);

            movieGroup.MapPost("/{movieId}/screenings", CreateScreening);
            movieGroup.MapGet("/{id}/screenings", GetAllScreenings);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            var entities = await repository.GetMovies();

            List<MovieDto> movies = new List<MovieDto>();


            foreach (var entity in entities)
            {
                var movie = new MovieDto()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Rating = entity.Rating,
                    Description = entity.Description,
                    RuntimeMins = entity.RuntimMins,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt,
                    Screenings = entity.Screenings.Select(x => new ScreeningDto()
                    {
                        Id = x.Id,
                        ScreenNumber = x.ScreenNumber,
                        Capacity = x.Capacity,
                        StartsAt = x.StartsAt,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt

                    }).ToList(),

                };
                movies.Add(movie);
            }

            PayLoad<List<MovieDto>> result = new PayLoad<List<MovieDto>>();
            result.data = movies;

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IMovieRepository repository, AddUpdateMovieDto movie)
        {
            var moviesEntities = await repository.GetMovies();
            if (moviesEntities.Any(m => m.Title == movie.Title))
            {
                return TypedResults.BadRequest("Movie with title already exists");
            }

            Movie entity = new Movie();

            entity.Title = movie.Title;
            entity.Rating = movie.Rating;
            entity.Description = movie.Description;
            entity.RuntimMins = movie.RuntimeMins;
            await repository.CreateMovie(entity);

            var movieDto = new MovieDto()
            {
                Id = entity.Id,
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimMins,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Screenings = entity.Screenings.Select(x => new ScreeningDto()
                {
                    Id = x.Id,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt

                }).ToList(),

            };

            PayLoad<MovieDto> result = new PayLoad<MovieDto>();
            result.data = movieDto;

            return TypedResults.Created(nameof(CreateMovie), result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, int id, AddUpdateMovieDto movie)
        {
            var entities = await repository.GetMovies();
            var entity = await repository.GetMovieById(id);

            if (!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Movie was not found");
            }

            entity.Title = movie.Title;
            entity.Rating = movie.Rating;
            entity.Description = movie.Description;
            entity.RuntimMins = movie.RuntimeMins;

            await repository.UpdateMovie(entity, id);

            var movieDto = new MovieDto()
            {
                Id = entity.Id,
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimMins,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Screenings = entity.Screenings.Select(x => new ScreeningDto()
                {
                    Id = x.Id,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt

                }).ToList(),

            };

            PayLoad<MovieDto> result = new PayLoad<MovieDto>();
            result.data = movieDto;

            return TypedResults.Created(nameof(CreateMovie), result);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            var entities = await repository.GetMovies();
            if (!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Movie not found");
            }

            var entity = await repository.GetMovieById(id);
            await repository.DeleteMovie(id);
            var movieDto = new MovieDto()
            {
                Id = entity.Id,
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimMins,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Screenings = entity.Screenings.Select(x => new ScreeningDto()
                {
                    Id = x.Id,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt

                }).ToList(),

            };

            PayLoad<MovieDto> result = new PayLoad<MovieDto>();
            result.data = movieDto;

            return TypedResults.Created(nameof(CreateMovie), result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IScreenRepository repository, [FromBody] AddUpdateScreeningDto screen, [FromHeader] int movieId)
        {
            var entities = await repository.GetScreenings();

            Screen entity = new Screen();

            entity.ScreenNumber = screen.ScreenNumber;
            entity.Capacity = screen.Capacity;
            entity.StartsAt = screen.StartsAt;
            entity.MovieId = movieId;
            await repository.CreateScreen(entity);

            ScreeningDto screeningDto = new ScreeningDto()
            {
                ScreenNumber = entity.ScreenNumber,
                Capacity = entity.Capacity,
                StartsAt = entity.StartsAt,
                CreatedAt = entity.CreatedAt,
            };

            
            PayLoad<ScreeningDto> result = new PayLoad<ScreeningDto>();

            return TypedResults.Created(nameof(CreateScreening), result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreenings(IMovieRepository movieRepository, 
            IScreenRepository screeningRepository, int movieid)
        {
            var entities = await screeningRepository.GetScreenings();

            List<ScreeningDto> screenings = new List<ScreeningDto>();

            foreach(var entity in entities)
            {
                if(entity.MovieId == movieid)
                {
                    var screen = new ScreeningDto()
                    {
                        Id = entity.Id,
                        ScreenNumber = entity.ScreenNumber,
                        Capacity = entity.Capacity,
                        StartsAt = entity.StartsAt,
                        CreatedAt = entity.CreatedAt,
                        UpdatedAt = entity.UpdatedAt,                      
                    };
                    screenings.Add(screen);
                }
            }

            PayLoad<List<ScreeningDto>> result = new PayLoad<List<ScreeningDto>>();
            result.data = screenings;

            return TypedResults.Ok(result);
        }

    }
}

