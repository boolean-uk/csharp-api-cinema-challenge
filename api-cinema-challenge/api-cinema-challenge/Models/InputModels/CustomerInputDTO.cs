namespace api_cinema_challenge.Models.InputModels
{
    public class CustomerInputDTO(string Name, string Email, string Phone)
    {
        public string Name { get; set; } = Name;

        public string Email { get; set; } = Email;

        public string Phone { get; set; } = Phone;
    }
}
