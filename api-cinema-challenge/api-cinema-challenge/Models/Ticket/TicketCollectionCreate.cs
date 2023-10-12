using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Ticket
{
    [NotMapped]
    public class TicketCollectionCreate
    {
        public string status { get; set; } = "success";
     
        public IEnumerable<Ticket> data { get; set; }
    }
}
