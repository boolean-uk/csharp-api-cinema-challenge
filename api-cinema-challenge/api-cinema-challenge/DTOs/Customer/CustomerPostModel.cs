using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.Customer
{
    public class CustomerPostModel
    {
        [Required(ErrorMessage = "Customer name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; }
    }
}
