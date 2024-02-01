namespace api_cinema_challenge.Models
{
    public class Movie
    {
                /*Copy
        {
        "id": 1,
        "title": "Dodgeball",
        "rating": "PG-13",
        "description": "The greatest movie ever made.",
        "runtimeMins": 126,
        "createdAt": "2023-03-14T11:01:56.633+00:00",
        "updatedAt": "2023-03-14T11:01:56.633+00:00"
        }*/


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int RuntimeMins { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
