using api_cinema_challenge.DTOs.Custommer;
using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ServiceResponse;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);



        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {

            //Soruce:
            var source = await repository.GetMovies();

            //Target & Transferring:

            List<OutMovieDTO> outData = source.Select(c => new OutMovieDTO
            {
               Id = c.Id,
               Rating = c.Rating,
               Title = c.Title,
               Runtime = c.Runtime,
               Description = c.Description,
               CreatedAt = c.CreatedAt,
               UpdatedAt =  c.UpdatedAt

            }).ToList();

            // Use the wrapper class to create a consisten response:
            var response = new ServiceResponse<List<OutMovieDTO>>
            {
                Data = outData,
                Status = "Success"
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository repository, [FromBody] InMovieDTO newMovie)
        {
            try
            {
                //Soruce:
                Movie source = await repository.AddMovie(newMovie);

                // Transferring:
                OutMovieDTO outData = new OutMovieDTO
                {
                    Id = source.Id,
                    Title = source.Title,
                    Description = source.Description,   
                    Rating  = source.Rating,
                    Runtime = source.Runtime,
                    CreatedAt = source.CreatedAt,
                    UpdatedAt = source.UpdatedAt
                };

                //Reponse:
                var response = new ServiceResponse<OutMovieDTO>
                {
                    Data = outData,
                    Status = "Success"
                };

                return TypedResults.Created(nameof(CreateMovie), response);
            }

            catch (BadHttpRequestException ex)
            {//Reponse:
                var response = new ServiceResponse<InMovieDTO>
                {
                    Data = newMovie,
                    Status = "Unsuccess"
                };

                return TypedResults.BadRequest(response);
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateMovie(IRepository repository, int id, [FromBody] InMovieDTO2 newMovie)
        {

            try
            {
                // Source:
                Movie source = await repository.UpdateMovie(id, newMovie);
                // Transferring:
                OutMovieDTO outData = new OutMovieDTO
                {
                    Id = source.Id,
                    Title = source.Title,
                    Description = source.Description,
                    Rating = source.Rating,
                    Runtime = source.Runtime,
                    CreatedAt = source.CreatedAt,
                    UpdatedAt = source.UpdatedAt
                };

                //Reponse:
                var response = new ServiceResponse<OutMovieDTO>
                {
                    Data = outData,
                    Status = "Success"
                };

                return TypedResults.Created(nameof(UpdateMovie), response);

            }

            catch (Exception ex)
            {

                var response = new ServiceResponse<InMovieDTO2>
                {
                    Data = newMovie,
                    Status = "Unsuccess"
                };

                return TypedResults.NotFound(response);

            }

        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            try
            {
                // Source:
                Movie source = await repository.DeleteMovie(id);

                // Transferring:
                OutMovieDTO outData = new OutMovieDTO
                {
                    Id = source.Id,
                    Title = source.Title,
                    Description = source.Description,
                    Rating = source.Rating,
                    Runtime = source.Runtime,
                    CreatedAt = source.CreatedAt,
                    UpdatedAt = source.UpdatedAt
                };

                //Reponse:
                var response = new ServiceResponse<OutMovieDTO>
                {
                    Data = outData,
                    Status = "Success"
                };

                return TypedResults.Ok(response);

            }

            catch (Exception ex)
            {
                var response = new ServiceResponse<InMovieDTO2>
                {

                    Status = "Unsuccess"
                };

                return TypedResults.NotFound(response);
            }
        }



    }


}
