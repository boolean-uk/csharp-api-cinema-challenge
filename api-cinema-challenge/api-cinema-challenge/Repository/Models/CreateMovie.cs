namespace api_cinema_challenge.Repository.Models
{
    public class CreateMovie
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RunTimeMins { get; set; }

        public List<MovieScreening> Screenings { get; set; } = new List<MovieScreening>();

        public class MovieScreening
        {
            public int ScreenNumber { get; set; }
            public int Capacity { get; set; }
            public DateTime StartsAt { get;set; }
        }
    }
}
