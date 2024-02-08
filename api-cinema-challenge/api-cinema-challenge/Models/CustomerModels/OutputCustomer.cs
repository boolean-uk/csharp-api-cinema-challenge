namespace api_cinema_challenge.Models.CustomerModels
{
    public class OutputCustomer
    {
        public required int Id { get; set; }

        public required DateTime CreatedAt { get; set; }

        public required DateTime UpdatedAt { get; set; }

        public required string Name { get; set; }

        public required string Phone { get; set; }

        public required string Email { get; set; }
    }
}
