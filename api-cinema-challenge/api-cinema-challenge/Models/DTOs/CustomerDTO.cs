using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime TimeCreated { get; set; }

        public DateTime TimeUpdated { get; set; }

    }
}
