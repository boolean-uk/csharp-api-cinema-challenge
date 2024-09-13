using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Payloads
{
    public class MoviePayload
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; } 
        public int RunTimeMins { get; set; }

        public List<ScreeningPayload> Screens { get; set; }

        public MoviePayload(string title, string rating, string description, int runTimeMins
            , List<ScreeningPayload> screens)
        {
            Title = title;
            Rating = rating;
            Description = description;
            RunTimeMins = runTimeMins;
            Screens = screens;
        }
    }
}
