using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class InputCustomerDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
