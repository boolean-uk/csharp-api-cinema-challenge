using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreenAPI
    {
        public static void ConfigureScreenAPI(this WebApplication app)
        {
            app.MapGet("/screens", GetScreens);
            app.MapGet("/screens/{id}", GetScreen);
            app.MapPost("/screens", AddScreen);
            app.MapPut("/screens", UpdateScreen);
            app.MapDelete("/screens", DeleteScreen);
        }

        private static async Task<IResult> GetScreens(IScreenRepository context)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(context.GetScreens());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetScreen(int id, IScreenRepository context)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var screen = context.GetScreen(id);
                    if (screen == null) return Results.NotFound();
                    return Results.Ok(screen);
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> AddScreen(Screen screen, IScreenRepository context)
        {
            try
            {
                if (context.AddScreen(screen)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> UpdateScreen(Screen screen, IScreenRepository context)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (context.UpdateScreen(screen)) return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteScreen(int id, IScreenRepository context)
        {
            try
            {
                if (context.DeleteScreen(id)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
