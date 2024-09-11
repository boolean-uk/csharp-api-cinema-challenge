using System.Text.RegularExpressions;

namespace api_cinema_challenge.Models
{
    internal static class Validation
    {
        internal static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
