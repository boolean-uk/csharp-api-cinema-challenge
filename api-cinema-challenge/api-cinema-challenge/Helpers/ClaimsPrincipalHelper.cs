using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace api_cinema_challenge.webapi
{
    public static class ClaimsPrincipalHelper
    {
        public static string? UserId(this ClaimsPrincipal user)
        {
            Claim? claim = user.FindFirst(ClaimTypes.NameIdentifier);
            return claim?.Value;
        }
        public static string? Email(this ClaimsPrincipal user)
        {
            Claim? claim = user.FindFirst(ClaimTypes.Email);
            return claim?.Value;
        }
            
        // public static string? UserId(this IIdentity identity)
        // {
        //   if (identity != null && identity.IsAuthenticated)
        //   {
        //     // return Guid.Parse(((ClaimsIdentity)identity).Claims.Where(x => x.Type == "NameIdentifier").FirstOrDefault()!.Value);
        //     return ((ClaimsIdentity)identity).Claims.Where(x => x.Type == "NameIdentifier").FirstOrDefault()!.Value;
        //   }
        //   return null;
        // }
    }
}
