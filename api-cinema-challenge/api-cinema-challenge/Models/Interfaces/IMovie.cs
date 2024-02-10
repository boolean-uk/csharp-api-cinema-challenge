namespace api_cinema_challenge.Models.Interfaces
{
    public interface IMovie
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
    }
}
