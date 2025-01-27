using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreenEndpoints
    {
        public static string Path { get; private set; } = "screens";
        public static void ConfigureScreensEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetScreens);
            group.MapPost("/", CreateScreen);
            group.MapGet("/{id}", GetScreen);
            group.MapDelete("/{id}", DeleteScreen);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreens(IRepository<Screen, int> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Screen> screens = await repository.GetAll();
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<ScreenView>>(screens) });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreen(IRepository<Screen, int> repository, IMapper mapper, int id)
        {
            try
            {
                Screen screen = await repository.Get(id);
                return TypedResults.Ok(mapper.Map<ScreenView>(screen));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateScreen(
            IRepository<Screen, int> repository,
            IMapper mapper,
            ScreenPost entity)
        {
            try
            {
                Screen screen = await repository.Add(new Screen
                {
                    Name = entity.Name,
                    Capacity = entity.Capacity,
                });
                screen = await repository.Add(screen);
                return TypedResults.Created($"{Path}/{screen.Id}", new Payload
                {
                    Data = mapper.Map<ScreenView>(screen)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteScreen(
            IRepository<Screen, int> repository,
            IMapper mapper,
            int id)
        {
            try
            {
                Screen screen = await repository.Delete(id);
                return TypedResults.Created($"{Path}/{screen.Id}", new Payload { Data = mapper.Map<ScreenView>(screen) });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
