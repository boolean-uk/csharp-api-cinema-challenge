namespace api_cinema_challenge.Models.TransferModels.Payload
{
    public class PayloadExtended<T>(T Data, int millis, int entries = 1) where T : class
    {
        public string status { get; set; } = "success";

        public int creationTimeInMillis { get; set; } = millis;

        public int entryNumber { get; set; } = entries;

        public T data { get; set; } = Data;
    }
}
