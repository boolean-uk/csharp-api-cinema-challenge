namespace api_cinema_challenge.Models.TransferModels.Payload
{
    public class PayloadExtended<T>(T Data, int millis, int entries = 1) where T : class
    {
        public string Status { get; set; } = "success";

        public int CreationTimeInMillis { get; set; } = millis;

        public int NumberOfEntries { get; set; } = entries;

        public T Data { get; set; } = Data;
    }
}
