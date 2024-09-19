namespace api_cinema_challenge.DTO
{
    public class CustomerDTOwithscreening
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public ScreeningDTO Screens { get; set; }
    }
}
