using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO.Pipes;
using System.Globalization;
using System.Net.Sockets;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {

        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapGet("/movies", GetMovies);
            // cinemaGroup.MapGet("/movies/{id}", GetMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);

        }

        /// MOVIES
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        { 

            var movies = await repository.GetMovies();

            List<Object> fstatus = new List<object>();


            foreach (Movie movie in movies)
            {
                MovieDTO dt = new MovieDTO(movie);

                fstatus.Add(dt);
            }

            var statusDTO = new StatusListDto(fstatus);

            return TypedResults.Ok(statusDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(CreateMoviePayload payload, IMovieRepository movieRepository, IRepository repository)
        {

            List<Screening> scrs = new List<Screening>();
         
            if (payload.title == "" || payload.rating == "" || payload.description == "" || payload.runtimeMins < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.title == null || payload.rating == null || payload.description == null )
            {
                return Results.BadRequest("Non-null fields are required");
            }
        
            Movie? movie = await movieRepository.CreateMovie(payload.title, payload.rating, payload.description, payload.runtimeMins);

            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            repository.SaveChanges(); // !!!

            if (payload.Screenings != null && payload.Screenings.Count() > 0)
            {
                foreach(CreateScreeningPayload sc in payload.Screenings)
                {

                    if (ValidationHelpers.correctDateTimeFormat(sc.startsAt) == false) 
                    {
                        return Results.BadRequest("Give datetime in the correct format: YYYY-MM-DD HH:MM:SS");
                    }

                    Screening? screening = await repository
                        .CreateScreening(
                        sc.screenNumber, 
                        sc.capacity, 
                        DateTime.Parse(sc.startsAt).ToUniversalTime(), 
                        movie.Id);

                    if (screening == null)
                    {
                        return Results.BadRequest("Screening could not be created!");
                    }
                }
                
            }

            repository.SaveChanges();

            MovieDTO mdto = new MovieDTO(movie);

            return TypedResults.Created($"/movies{movie.Id}", new StatusSingleDto( mdto ));
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteMovie(int id, IMovieRepository repository)
        {

            Movie? movie = await repository.DeleteMovie(id, PreloadPolicy.PreloadRelations);

            if (movie == null)
            {
                return Results.NotFound("Movie not found");
            }

            var MovieDTO = new MovieDTO(movie);
            var StatusDTO = new StatusSingleDto( MovieDTO );

            repository.SaveChanges();

            return TypedResults.Ok(StatusDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(int id, UpdateMoviePayload payload, IMovieRepository repository)
        {


            // nothing to update
            if (payload.title == "" && payload.rating == "" && payload.description == "" && payload.runtimeMins < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.title == null || payload.rating == null || payload.description == null || payload.runtimeMins == null)
            {
                return Results.BadRequest("Non-null fields are required");
            }

            Movie ogMovie = repository.GetMovies().Result.FirstOrDefault(x => x.Id == id);

            if (ogMovie == null)
            {
                return Results.BadRequest("Movie not found");
            }

            string newTitle = (payload.title.Length > 0) ? payload.title : ogMovie.Title;
            string newRating = (payload.rating.Length > 0) ? payload.rating : ogMovie.Rating;
            string newDescription = (payload.description.Length > 0) ? payload.description : ogMovie.Description;
            int newRuntimeMins = (payload.runtimeMins != ogMovie.RuntimeMins && payload.runtimeMins != 0) ? payload.runtimeMins : ogMovie.RuntimeMins;
        
            Movie? movie = await repository.UpdateMovie(id, newTitle, newRating, newDescription, newRuntimeMins);

            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }


            MovieDTO mv = new MovieDTO(movie);
            StatusSingleDto sto = new StatusSingleDto( mv );

            repository.SaveChanges();

            return TypedResults.Created($"/movies{movie.Id}", sto);
        }

    }
}
