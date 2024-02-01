namespace api_cinema_challenge.Models.Payloads
{
    public record CustomerPayload
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string CheckPayload()
        {
            if (string.IsNullOrWhiteSpace(Name)) { return "Name is required"; }
            if (IsValidEmail() == false) { return "Email is required"; }
            if (string.IsNullOrWhiteSpace(Phone)) { return "Phone nr is required"; }

            return string.Empty;
        }

        public bool IsValidEmail()
        {
            var trimmedEmail = Email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}