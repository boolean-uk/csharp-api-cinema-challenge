using System.ComponentModel;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DefaultValue("")]
        public string Name { get; set; }
        [DefaultValue("")]
        public string Email { get; set; }
        [DefaultValue("")]

        public string Phone { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
