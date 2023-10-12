using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Screen;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreenApi
    {
        public static void ConfigureScreenApi(this WebApplication application)
        {
            application.MapGet("/movies/{id}/screenings", GetScreens);
            application.MapPost("/movies/{id}/screenings ", AddScreen);
        }

        /* [ProducesResponseType(StatusCodes.Status200OK)]
         public static async Task<IResult> GetScreens(int movieId, IRepository repository)
         {
             try
             {
                 var screenings = repository.GetScreens();
                 if (screenings.Any())
                 {
                     Payload<List<Screen>> payload = new Payload<List<Screen>>();
                     payload.data = screenings;
                     return Results.Ok(payload);
                 }
                 return Results.NotFound();
             }
             catch (Exception ex)
             {
                 return Results.Problem(ex.Message);
             }
         }*/

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreens(int Id, IRepository repository)
        {
            try
            {
                ScreenCollectionCreate screenCollectionCreate = new ScreenCollectionCreate();
                screenCollectionCreate.data = repository.GetScreens().Where(s => s.movieId == Id).ToList();
                return screenCollectionCreate.data != null ? Results.Ok(screenCollectionCreate) : Results.Problem();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddScreen(int id, ScreenPost screenPost, IRepository repository)
        {
            try
            {
                Screen screen = new Screen();
                screen.screenNumber = screenPost.screenNumber;
                screen.capacity = screenPost.capacity;
                screen.startsAt = DateTime.UtcNow;

                var movie = repository.GetMovie(id);
                if (movie == null)
                {
                    return Results.BadRequest("Movie not found.");
                }

                screen.movieId = id;
                screen.createdAt = DateTime.UtcNow;
                screen.updatedAt = DateTime.UtcNow;

                if (repository.AddScreen(screen))
                {
                    ScreenCreate screenCreate = new ScreenCreate();
                    screenCreate.data = screen;
                    return Results.Created("https://localhost:7195/screens", screenCreate);
                }

                return Results.Problem();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        
    }
}
