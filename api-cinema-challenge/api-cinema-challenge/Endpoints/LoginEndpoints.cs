using System.IdentityModel.Tokens.Jwt;
using System.Text;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

public static class LoginEndpoints
{
    public static void MapLoginEndpoints(this WebApplication app, IConfiguration config)
    {
        var jwtSettings = config.GetSection("Jwt");

        app.MapPost("/login", async (LoginRequest login, CinemaContext db) =>
        {
            var user = await db.Customers.SingleOrDefaultAsync(u => u.Name == login.Name);
            if (user == null || user.Password != login.Password)
                return Results.Unauthorized();

            var key = Encoding.UTF8.GetBytes(jwtSettings.GetValue<string>("Key"));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new System.Security.Claims.Claim("id", user.Id.ToString())
                }),

                Expires = DateTime.UtcNow.AddMinutes(jwtSettings.GetValue<int>("ExpiryMinutes")),
                Issuer = jwtSettings["Issuer"],
                Audience = jwtSettings["Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };


            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwt = tokenHandler.WriteToken(token);

            return Results.Ok(new { Token = jwt });
        })
        .WithTags("Authentication");

    }
    
}
