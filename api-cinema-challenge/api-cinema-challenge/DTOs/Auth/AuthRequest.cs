using System.ComponentModel.DataAnnotations;
using System.Data;

namespace api_cinema_challenge.DTOs.Auth;

public class AuthRequest
{
    public string? Email { get; set; }
    public string? Password { get; set; }

    public bool IsValid()
    {
        return true;
    }
}
