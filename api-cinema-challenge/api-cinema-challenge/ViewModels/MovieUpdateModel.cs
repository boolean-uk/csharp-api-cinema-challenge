using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class MovieUpdateModel
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
