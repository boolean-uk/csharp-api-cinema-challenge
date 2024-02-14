namespace api_cinema_challenge.Utils
{
    public static class TimeGenerator
    {
        public static DateTime GenerateUTCTimeDate(Random rng, int startYear, int endYear) 
        {
            return DateTime
                .SpecifyKind(new DateTime(
                        rng.Next(startYear, endYear),
                        rng.Next(1, 12),
                        rng.Next(1, 29),
                        rng.Next(0, 24),
                        rng.Next(0, 60),
                        rng.Next(0, 60)
                    ), 
                    DateTimeKind.Utc);
        }
    }
}
