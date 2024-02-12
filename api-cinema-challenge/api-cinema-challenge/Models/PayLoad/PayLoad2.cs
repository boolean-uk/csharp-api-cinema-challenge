namespace api_cinema_challenge.Models.PayLoad
{
    internal class Payload2<T1, T2> where T1 : class where T2 : class
    {
        public string status { get; set; } = "success";
        public T1 dataOne { get; set; }
        public T2 dataTwo { get; set; }
    }
}
