using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Post;

public class PostScreening
{
    public int screenNumber { get; set; }
    public int capacity { get; set; }
    public DateTime StartsAt { get; set; }
}
