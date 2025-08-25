namespace api_cinema_challenge.Factories
{
    public static class ResponseFactory
    {
        public static Object Failure()
        {
            return new { status = "failure"};
        }

        public static Object Success()
        {
            return new { status = "success" };
        }
    }
}
