using System.ComponentModel.DataAnnotations.Schema;


namespace api_cinema_challenge.Models
{

    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class UsersResponseDTO
    {
        public int ID { get; set; }
        public string name { get; set; }

        public UsersResponseDTO(User user)
        {
            name = user.Name;
            ID = user.Id;
        }
    }

}
