using System.Security.Claims;

namespace api_cinema_challenge.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static int? GetId(this ClaimsPrincipal claimsPrincipal)
    {
        var claim = claimsPrincipal.FindFirst(ClaimTypes.Sid);
        if (claim == null)
        {
            return null;
        }
        
        return int.Parse(claim.Value);
    }
}