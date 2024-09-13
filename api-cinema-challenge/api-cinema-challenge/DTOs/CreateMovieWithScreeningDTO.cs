namespace api_cinema_challenge.DTOs
{
    public class CreateMovieWithScreeningDTO
    {

        public string name { get; set; }

        public int rating { get; set; }

        public string description { get; set; }

        public int runTimemins { get; set; }

        public int number { get; set; }

        public DateTime startsAt { get; set; }

        public int capacity { get; set; }

    }
}
