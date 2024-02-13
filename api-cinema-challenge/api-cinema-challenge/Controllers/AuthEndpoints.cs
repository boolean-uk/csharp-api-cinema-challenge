using api_cinema_challenge.DTOs;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Win32;

namespace api_cinema_challenge.Controllers
{
    public static class AuthEndpoints
    {
        public static void ConfigureAuthEndpoints(this
        WebApplication app)
        {
            var taskGroup = app.MapGroup("auth");
            taskGroup.MapPost("/register/{isManager}", Register);
            taskGroup.MapPost("/register", Register);
            taskGroup.MapPost("/login", Login);
        }

        public async static Task<IResult> Register(RegisterDTO payload, ICustomerRepository customerRepository, UserManager<ApplicationUser> userManager, string isManager = "false")
        {
            UserRole role = UserRole.Customer;
            if (isManager == "true") role = UserRole.Manager;
            if (payload.Username is null) return TypedResults.BadRequest("Username is required");
            if (payload.Email is null) return TypedResults.BadRequest("Email is required");
            if (payload.Password is null) return TypedResults.BadRequest("Password is required");
            var result = await userManager.CreateAsync(
                new ApplicationUser
                    {
                        UserName = payload.Username,
                        Email = payload.Email,
                        Role = role,
                        PhoneNumber = payload.Phonenumber
                    },
                    payload.Password
                );;
            if (result.Succeeded)
            {
                Customer customer = await customerRepository.CreateCustomer(payload.Username, payload.Email, payload.Phonenumber);
                return TypedResults.Created("/auth", new Payload<Customer>() { data = customer });
            }
            return Results.BadRequest(result.Errors);
        }

        public static async Task<IResult> Login(LoginDTO payload, UserManager<ApplicationUser> userManager, TokenService tokenService)
        {
            //check payload
            if (payload.Username == null) return TypedResults.BadRequest("Username is required");
            if (payload.Password == null) return TypedResults.BadRequest("Password is required");

            //load user from database
            var user = await userManager.FindByNameAsync(payload.Username);
            if (user is null)
            {
                return TypedResults.BadRequest("Invalid username or password");
            }
            //check password matches
            bool isPasswordValid = await userManager.CheckPasswordAsync(user, payload.Password);
            if (!isPasswordValid)
            {
                return TypedResults.BadRequest("Invalid username or password");
            }
            //create a token
            var token = tokenService.CreateToken(user);

            //return the response
            return TypedResults.Ok(new LoginResponseDTO(token, user.UserName, user.Role));
        }

    }
}
