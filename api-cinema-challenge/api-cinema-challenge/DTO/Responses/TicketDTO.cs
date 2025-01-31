using System;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Responses;

public class TicketDTO
{

    public int Id { get; set; }
    public int NumSeats { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
