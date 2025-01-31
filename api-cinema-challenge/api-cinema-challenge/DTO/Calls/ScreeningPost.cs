using System;

namespace api_cinema_challenge.DTO.Calls;

public class ScreeningPost
{
    public int ScreenNumber { get; set; }
    public int Capacity { get; set; }
    public DateTime StartsAt { get; set; }
}
