namespace api_cinema_challenge.Models.Movie
{
    public static class MovieMapper
    {
        public static MovieDTO MapToDTO(this Movie movie)
        {
            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                runtimeMins = movie.runtimeMins,
                Screenings = movie.Screenings
            };
        }

        public static List<MovieDTO> MapListToDTO(this List<MovieDTO> movies)
        {
            return movies.Select(movie => new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                runtimeMins = movie.runtimeMins,
                Screenings = movie.Screenings
            }).ToList();
        }
    }
}
