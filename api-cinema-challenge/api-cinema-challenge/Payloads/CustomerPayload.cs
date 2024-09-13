using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Payloads
{
    public class CustomerPayload
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public CustomerPayload(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
