using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieAPI
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var MovieGroup = app.MapGroup("/movies");

            MovieGroup.MapGet("", GetMovies);
            MovieGroup.MapPost("", Createmovie);
            MovieGroup.MapPut("/{id}", UpdateMovie);
            MovieGroup.MapDelete("/{id}", DeleteMovie);

            MovieGroup.MapGet("/{movieId}/screenings", GetScreenings);
            MovieGroup.MapPost("/{movieId}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(IRepository<Movie> repository, IMapper mapper)
        {
            var movies = await repository.Get();
            List<MovieGet> movielist = mapper.Map<List<MovieGet>>(movies);
            ApiResponse<List<MovieGet>> response = new ApiResponse<List<MovieGet>>(movielist);
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Createmovie(IRepository<Movie> repository, IRepository<Screening> screenrep, IMapper mapper, MoviePost model)
        {
            if (model == null) TypedResults.NotFound(new ApiResponse<string>("Invalid information given."));
            // insert movie
            Movie movie = mapper.Map<Movie>(model);
            ICollection<Screening> screenings = movie.Screenings;
            movie = await repository.Insert(movie);
            movie.Screenings.Clear();

            // insert screenings
            foreach(var screeningPost in model.Screenings) {
                Screening screening = mapper.Map<Screening>(screeningPost);
                screening.MovieId = movie.Id;
                await screenrep.Insert(screening);
                // Dont need to add the screenings, cuz somehow it tracks it?
                //movie.Screenings.Add(screening);
            }

            MovieGetScreenings movieScreeningsDTO = mapper.Map<MovieGetScreenings>(movie);

            return TypedResults.Ok(movieScreeningsDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateMovie(IRepository<Movie> repository, IMapper mapper, int id, MoviePut model)
        {
            if (model == null) return TypedResults.NotFound(new ApiResponse<string>("Invalid information given."));
            Movie? movie = await repository.GetById(id);
            if (movie == null) return TypedResults.NotFound(new ApiResponse<string>("No customer with Id"));

            if (!string.IsNullOrWhiteSpace(model.Title)) movie.Title = model.Title;
            if (!string.IsNullOrWhiteSpace(model.Rating)) movie.Rating = model.Rating;
            if (!string.IsNullOrWhiteSpace(model.Description)) movie.Description = model.Description;
            if (model.RuntimeMins > 0) movie.RuntimeMins = model.RuntimeMins;


            Movie updatedMovie = await repository.Update(movie);
            MovieGet movieDTO = mapper.Map<MovieGet>(updatedMovie);
            return TypedResults.Created($"/movies/{movieDTO.Id}", new ApiResponse<MovieGet>(movieDTO));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(IRepository<Movie> repository, IMapper mapper, int id)
        {
            var result = await repository.Delete(id);
            return result != null ? TypedResults.Ok(new ApiResponse<MovieGet>(mapper.Map<MovieGet>(result))) : TypedResults.NotFound("Not valid ID");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreenings(IRepository<Screening> repository, IMapper mapper, int MovieId)
        {
            var screening = await repository.Get(t => t.MovieId == MovieId);
            return TypedResults.Ok(new ApiResponse<List<ScreeningGet>>(mapper.Map<List<ScreeningGet>>(screening)));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateScreening(IRepository<Screening> repository, IMapper mapper, int MovieId, ScreeningPost model)
        {
            if (model == null || model.Capacity <= 0 || model.ScreenNumber == 0) TypedResults.NotFound(new ApiResponse<string>("Need to give a number bigger than 0."));
            Screening screening = mapper.Map<Screening>(model);
            screening.MovieId = MovieId;
            screening = await repository.Insert(screening);
            return TypedResults.Ok(new ApiResponse<ScreeningGet>(mapper.Map<ScreeningGet>(screening)));
        }
    }
}
