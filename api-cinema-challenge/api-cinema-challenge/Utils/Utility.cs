using System.Text.Json;

namespace api_cinema_challenge.Utils
{
    public static class Utility
    {
        public static async Task<T> ValidateFromRequest<T>(HttpRequest request)
        {
            T? entity;
            try
            {
                entity = await request.ReadFromJsonAsync<T>();
            }
            catch (JsonException ex)
            {
                return default;
            }
            catch (Exception ex)
            {
                return default;
            }

            return entity;
        }
    }
}
