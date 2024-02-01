using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class UserAllDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserAllDetailsDTO(User user)
        {
            Id = user.UserId;
            Name = user.Name;
            Email = user.Email;
            Phonenumber = user.Phone;
            CreatedAt = user.Created_at;
            UpdatedAt = user.Updated_at;
        }
    }
}
