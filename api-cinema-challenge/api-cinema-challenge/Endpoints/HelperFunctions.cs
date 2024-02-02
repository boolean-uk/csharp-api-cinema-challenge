using System.Globalization;

namespace api_cinema_challenge.Endpoints
{
    public class HelperFunctions
    {

        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool correctDateTimeFormat(string inputString)
        {
            return DateTime.TryParseExact(inputString, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);
        }
    }
}
