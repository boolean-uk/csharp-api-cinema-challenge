namespace api_cinema_challenge.Models
{
    public class ScreeningPayload
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }



        public string CheckPayload()
        {
            if (int.IsNegative(Capacity)) { return "Capacity cant be negative"; }
            if (StartsAt < DateTime.Now) { return "Can't create screening for a day that already has been"; }
            return string.Empty;
        }
    }
}
