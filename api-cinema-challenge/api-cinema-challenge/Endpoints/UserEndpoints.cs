using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using api_cinema_challenge.DTOs.User.Login;
using api_cinema_challenge.DTOs.User.Register;
using api_cinema_challenge.Models;
using exercise.wwwapi.Configuration;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace api_cinema_challenge.Endpoints;

public static class UserEndpoints
{
    public static void ConfigureUserEndpoints(this WebApplication app)
    {
        var auth = app.MapGroup("auth");
        auth.MapPut("register", Register);
        auth.MapPut("login", Login);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    private static async Task<IResult> Register(IRepository<User> repository, RegisterRequestDTO request)
    {
        var users = await repository.GetAllAsync();
        if (users.Any(user => user.Username == request.Username))
        {
            return Results.Conflict("Username already exists");
        }

        var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        var user = new User
        {
            Username = request.Username,
            PasswordHash = passwordHash,
        };

        repository.Insert(user);
        await repository.SaveAsync();

        return Results.Ok(new RegisterSuccessDTO
        {
            Username = request.Username,
        });
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    private static async Task<IResult> Login(IRepository<User> repository, LoginRequestDTO request, IConfigurationSettings configurationSettings)
    {
        var users = await repository.GetAllAsync();

        var user = users.FirstOrDefault(u => u.Username == request.Username);
        if (user == null)
        {
            return Results.BadRequest("User does not exist");
        }

        if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            return Results.BadRequest("Failed");
        }

        var token = CreateToken(user, configurationSettings);
        return Results.Ok(new LoginSuccessDTO
        {
            Token = token,
        });
    }

    private static string CreateToken(User user, IConfigurationSettings configurationSettings)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.Sid, user.Id.ToString()),
            new(ClaimTypes.Name, user.Username),
        };

        var rawToken = configurationSettings.GetValue("Token");

        if (rawToken == null)
        {
            throw new Exception("No token found!");
        }

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(rawToken));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials
        );
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        return jwt;
    }
}