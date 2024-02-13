using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Services;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.Utils;



namespace api_cinema_challenge.Endpoints
{


    public static class AuthEndpoints
    {
        public static void ConfigureAuthEndpoints(this WebApplication app)
        {
            var taskGroup = app.MapGroup("auth");
            taskGroup.MapPost("/register/customer", RegisterCustomer);
            taskGroup.MapPost("/register/manager", RegisterManager);
            taskGroup.MapPost("/login", Login);
        }




        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> RegisterCustomer(
          RegisterDto registerPayload,
          UserManager<ApplicationUser> userManager)
        {
            if (registerPayload.Email == null) return TypedResults.BadRequest("Email is required.");
            if (registerPayload.Password == null) return TypedResults.BadRequest("Password is required.");

            string newID = Guid.NewGuid().ToString();

            var result = await userManager.CreateAsync(

                new ApplicationUser { Id = newID, UserName = registerPayload.Email, Email = registerPayload.Email, Role = UserRole.Customer },

              registerPayload.Password!
            );

            if (result.Succeeded)
            {
                return TypedResults.Created($"/auth/", new { email = registerPayload.Email, role = UserRole.Customer });
            }
            return Results.BadRequest(result.Errors);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> RegisterManager(
        RegisterDto registerPayload,
        UserManager<ApplicationUser> userManager)
        {
            if (registerPayload.Email == null) return TypedResults.BadRequest("Email is required.");
            if (registerPayload.Password == null) return TypedResults.BadRequest("Password is required.");

            string newID = Guid.NewGuid().ToString();

            var result = await userManager.CreateAsync(

                new ApplicationUser { Id = newID, UserName = registerPayload.Email, Email = registerPayload.Email, Role = UserRole.Manager },

              registerPayload.Password!
            );

            if (result.Succeeded)
            {
                return TypedResults.Created($"/auth/", new { email = registerPayload.Email, role = UserRole.Manager });
            }
            return Results.BadRequest(result.Errors);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> Login(
          LoginDto loginPayload,
          UserManager<ApplicationUser> userManager,
          TokenService tokenService,
          IUserRepository repository)
        {
            if (loginPayload.Email == null) return TypedResults.BadRequest("Email is required.");
            if (loginPayload.Password == null) return TypedResults.BadRequest("Password is required.");

            var user = await userManager.FindByEmailAsync(loginPayload.Email!);
            if (user == null)
            {
                return TypedResults.BadRequest("Invalid email or password.");
            }

            var isPasswordValid = await userManager.CheckPasswordAsync(user, loginPayload.Password);
            if (!isPasswordValid)
            {
                return TypedResults.BadRequest("Invalid email or password.");
            }

            var userInDb = repository.GetUser(loginPayload.Email);

            if (userInDb is null)
            {
                return Results.Unauthorized();
            }

            var accessToken = tokenService.CreateToken(userInDb);

            return TypedResults.Ok(new AuthResponseDto(accessToken, userInDb.Email, userInDb.Role));
        }

    }
}