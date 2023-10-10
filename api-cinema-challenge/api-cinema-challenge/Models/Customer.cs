using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Required]public int Id { get; set; }
        [Required] public string name { get; set; }
        [Required] public string email { get; set; }
        [Required] public string phone { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
