namespace api_cinema_challenge.Models.CustomerModels
{
    public class OutputCustomer
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
