namespace api_cinema_challenge.Models.TransferModels.Customer
{
    public class CustomerDTO(int Id, string Name, string Email, string Phone, DateTime created, DateTime updated)
    {
        public int Id { get; set; } = Id;

        public string Name { get; set; } = Name;

        public string Email { get; set; } = Email;

        public string Phone { get; set; } = Phone;

        public string createdAt { get; set; } = created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string updatedAt { get; set; } = updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
    }
}
