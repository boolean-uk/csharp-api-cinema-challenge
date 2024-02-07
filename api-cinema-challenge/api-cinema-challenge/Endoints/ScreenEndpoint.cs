using api_cinema_challenge.Model;
using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endoints
{
    public static class ScreenEndpoint
    {
        public static void ConfigureScreenEndpoint(this WebApplication app)
        {
            var screenGroup = app.MapGroup("screen");

            // Screen endpoints
            screenGroup.MapGet("/screens" , GetScreens);
            screenGroup.MapGet("/screens/{id}" , GetScreenById);
            screenGroup.MapPost("/screens" , CreateScreen);
            screenGroup.MapPut("/screens/{id}" , UpdateScreen);
            screenGroup.MapDelete("/screens/{id}" , DeleteScreen);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreens(IScreenRepository repository)
        {
            return TypedResults.Ok(await repository.GetAllScreens());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenById(IScreenRepository repository , int id)
        {
            var screen = await repository.GetScreen(id);
            if(screen == null)
            {
                return Results.NotFound($"Screen with ID {id} not found.");
            }
            return Results.Ok(screen);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreen(IScreenRepository repository , ScreenDto screenDto)
        {
            var screen = new Screen
            {
                ScreenNumber = screenDto.ScreenNumber
            };

            screen = await repository.CreateScreen(screen);
            return Results.Created($"/screens/{screen.Id}" , screen);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateScreen(IScreenRepository repository , int id , ScreenDto screenDto)
        {
            var screen = new Screen
            {
                ScreenNumber = screenDto.ScreenNumber
            };

            screen = await repository.UpdateScreen(id , screen);
            if(screen == null)
            {
                return Results.NotFound($"Screen with ID {id} not found.");
            }
            return Results.Ok(screen);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteScreen(IScreenRepository repository , int id)
        {
            var screen = await repository.DeleteScreen(id);
            if(screen == null)
            {
                return Results.NotFound($"Screen with ID {id} not found.");
            }
            return Results.Ok(screen);
        }
    }
}
