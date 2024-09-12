using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Payloads
{
    public class MoviePayload
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; } 
        public int RunTimeMins { get; set; }

        public MoviePayload(string title, string rating, string description, int runTimeMins)
        {
            Title = title;
            Rating = rating;
            Description = description;
            RunTimeMins = runTimeMins;
        }
    }
}
