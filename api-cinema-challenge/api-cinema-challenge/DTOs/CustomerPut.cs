using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs
{
    public class CustomerPut
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
