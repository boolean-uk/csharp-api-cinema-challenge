using Microsoft.EntityFrameworkCore.Storage;

namespace api_cinema_challenge.Models
{
    public record TicketsPostPayload(int customerid, int screeningid, int numSeats);
}