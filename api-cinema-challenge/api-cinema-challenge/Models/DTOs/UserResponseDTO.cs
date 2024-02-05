namespace api_cinema_challenge.Models.DTOs
{
    //DTO
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