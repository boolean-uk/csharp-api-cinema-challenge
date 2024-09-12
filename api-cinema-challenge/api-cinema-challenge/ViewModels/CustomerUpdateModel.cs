using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class CustomerUpdateModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
