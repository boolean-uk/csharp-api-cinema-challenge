using api_cinema_challenge.DTO.Requests;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var m = app.MapGroup("/movies");

            m.MapPost("/", CreateMovie);
            m.MapGet("/", GetMovies);
            m.MapPost("/{id}", UpdateMovie);
            m.MapDelete("/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovie(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, IMapper mapper, MovieRequestDto movieDto)
        {
            var movie = mapper.Map<Movie>(movieDto);
            var createdMovie = await movieRepository.Insert(movie);
            await movieRepository.Save();

            if (movieDto.screeningRequestDtos != null && movieDto.screeningRequestDtos.Any())
            {
                var screenings = mapper.Map<IEnumerable<Screening>>(movieDto.screeningRequestDtos);
                foreach (var screening in screenings)
                {
                    screening.MovieId = createdMovie.Id;
                    await screeningRepository.Insert(screening);
                }
                await screeningRepository.Save();
            }

            var movieResponse = mapper.Map<MovieResponseDto>(createdMovie);

            var response = new Payload { Status = "success", Data = movieResponse };
            return TypedResults.Created($"/movies/{createdMovie.Id}", response);
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(IRepository<Movie> repository, IMapper mapper)
        {
            var movies = await repository.Get();
            var movieDtos = mapper.Map<IEnumerable<MovieResponseDto>>(movies);
            var response = new Payload { Status = "success", Data = movieDtos };
            return TypedResults.Ok(response);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateMovie(IRepository<Movie> repository, IMapper mapper, int id, MovieUpdateDto updateDto)
        {
            var movie = await repository.GetById(id);
            if (movie == null)
            {
                var response = new Payload { Status = "error: Movie not found" };
                return TypedResults.NotFound(response);
            }
            if (updateDto.Title != null) movie.Title = updateDto.Title;
            if (updateDto.Rating != null) movie.Rating = updateDto.Rating;
            if (updateDto.Description != null) movie.Description = updateDto.Description;
            if (updateDto.RuntimeMins != null) movie.RuntimeMins = (int)updateDto.RuntimeMins;
            await repository.Update(movie);
            await repository.Save();
            var movieResponse = mapper.Map<MovieResponseDto>(movie);
            var responseOk = new Payload { Status = "success", Data = movieResponse };
            return TypedResults.Ok(responseOk);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(IRepository<Movie> repository, IMapper mapper, int id)
        {
            var movie = await repository.GetById(id);
            if (movie == null)
            {
                var response = new Payload { Status = "error: Movie not found" };
                return TypedResults.NotFound(response);
            }
            await repository.Delete(id);
            await repository.Save();
            var movieResponse = mapper.Map<MovieResponseDto>(movie);
            var responseOk = new Payload { Status = "success", Data = movieResponse };
            return TypedResults.Ok(responseOk);
        }
    }
}
