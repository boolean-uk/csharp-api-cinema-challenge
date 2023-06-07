using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
       

        public string Email { get; set; }
        [Required]

        public string Phone { get; set; }
       // [JsonIgnore(Condition = HttpContext.Request.Method == "POST")]

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        
        public DateTime UpdatedDate { get; set;} = DateTime.UtcNow;

    }
}
