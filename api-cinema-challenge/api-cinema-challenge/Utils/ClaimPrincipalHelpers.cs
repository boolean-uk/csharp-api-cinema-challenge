using System.Security.Claims;
using System.Security.Principal;

namespace api_cinema_challenge.Utils
{
    public static class ClaimsPrincipalHelpers
    {
        public static string? UserId(this ClaimsPrincipal user)
        {
            Claim? claim = user.FindFirst(ClaimTypes.NameIdentifier);
            // new Claim(JwtRegisteredClaimNames.Sub, jwtSub);
            return claim?.Value;
        }

        public static string? UserRole(this ClaimsPrincipal user)
        {
            Claim? claim = user.FindFirst(ClaimTypes.Role);
            return claim?.Value;
        }

        public static string? UserEmail(this ClaimsPrincipal user)
        {
            Claim? claim = user.FindFirst(ClaimTypes.Email);
            return claim?.Value;
        }

    }

}
