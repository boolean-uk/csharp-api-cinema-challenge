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
                rating = movie.rating,
                Description = movie.Description,
                runtimeMins = movie.runtimeMins,
                Screenings = movie.Screenings,
                createdAt = movie.createdAt,
                updatedAt = movie.updatedAt,
            };
        }

        public static List<MovieDTO> MapListToDTO(this List<Movie> movies)
        {
            return movies.Select(movie => new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                rating = movie.rating,
                Description = movie.Description,
                runtimeMins = movie.runtimeMins,
                Screenings = movie.Screenings,
                createdAt = movie.createdAt,
                updatedAt = movie.updatedAt,
            }).ToList();
        }
    }
}
