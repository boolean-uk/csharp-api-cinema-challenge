using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class CustomerPost
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
