using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        /*{

    "id": 1,
    "screenNumber": 5,
    "capacity": 40,
    "startsAt": "2023-03-19T11:30:00.000+00:00",
    "createdAt": "2023-03-14T11:01:56.633+00:00",
    "updatedAt": "2023-03-14T11:01:56.633+00:00"

}*/
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }


        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        public int? MovieId { get; set; }

    }
}
