namespace api_cinema_challenge.Models
{
    public class BookingPayload
    {
        //public int CustomerId { get; set; }

        public int ScreeningId { get; set; }

        public int ticketQuantity { get; set; }

        public string CheckPayload()
        {
            if (ticketQuantity <= 0) { return "Can't book less than 1 ticket"; }
            return string.Empty;
        }
    }
}
