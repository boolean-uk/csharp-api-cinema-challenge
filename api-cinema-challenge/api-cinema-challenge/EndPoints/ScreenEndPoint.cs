using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace workshop.wwwapi.Endpoints
{
    public class ScreenPayload
    {
        public string? Name { get; set; }

        public bool AllFieldsFilled()
        {
            return !string.IsNullOrEmpty(Name);
        }
    }

    public static class ScreenEndpoint
    {
        public static void ConfigureScreenEndpoint(this WebApplication app)
        {
            var screenGroup = app.MapGroup("screens");

            screenGroup.MapGet("/", GetAllScreens);
            screenGroup.MapGet("/{id}", GetScreenById);
            screenGroup.MapPost("/", CreateAScreen);
            screenGroup.MapPut("/{id}", UpdateScreenById);
            screenGroup.MapDelete("/{id}", DeleteScreenById);
        }

        public static async Task<IResult> GetAllScreens(IScreenRepository repository)
        {
            var screens = await repository.GetAll();
            return Results.Ok(ScreenDTO.FromListOfScreens(screens));
        }

        public static async Task<IResult> GetScreenById(int id, IScreenRepository repository)
        {
            var screen = await repository.GetScreenById(id);
            if (screen == null) return Results.NotFound();
            return Results.Ok(ScreenDTO.FromScreen(screen));
        }

        public static async Task<IResult> CreateAScreen(ScreenPayload payload, IScreenRepository repository)
        {
            if (!payload.AllFieldsFilled()) return Results.BadRequest("All fields are required.");

            var newScreen = new Screen
            {
                name = payload.Name,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var createdScreen = await repository.CreateAScreen(newScreen);
            return Results.Created($"/screens/{createdScreen.id}", ScreenDTO.FromScreen(createdScreen));
        }

        public static async Task<IResult> UpdateScreenById(int id, ScreenPayload payload, IScreenRepository repository)
        {
            if (!payload.AllFieldsFilled()) return Results.BadRequest("All fields are required.");

            var updatedScreen = await repository.UpdateAScreen(id, payload.Name);

            if (updatedScreen == null) return Results.NotFound();
            return Results.Ok(ScreenDTO.FromScreen(updatedScreen));
        }

        public static async Task<IResult> DeleteScreenById(int id, IScreenRepository repository)
        {
            var deletedScreen = await repository.DeleteAScreen(id);
            if (deletedScreen == null) return Results.NotFound();

            return Results.Ok(ScreenDTO.FromScreen(deletedScreen));
        }
    }
}
