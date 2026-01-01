namespace api_cinema_challenge.Extensions
{
    public static class Http_context_extension
    {
        public static string Get_endpointUrl<T>(this HttpContext context, T indexVal)
        {
            string schemeType = context.Request.Scheme;
            string local = context.Request.Host.ToUriComponent();
            string path = context.Request.Path;
            return string.Format($"{schemeType}://{local}{path}/{{0}}", indexVal);
        }
    }
}
