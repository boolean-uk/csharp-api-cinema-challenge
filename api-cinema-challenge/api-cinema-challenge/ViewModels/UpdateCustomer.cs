using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class UpdateCustomer
    {
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone must be in the format XXX-XXX-XXXX.")]
        public string Phone { get; set; }
    }
}
