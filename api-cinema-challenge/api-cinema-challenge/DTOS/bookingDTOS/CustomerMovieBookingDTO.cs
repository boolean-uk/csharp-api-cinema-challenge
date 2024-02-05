namespace api_cinema_challenge.Models.DTOS.movieDTOS
{
    public class CustomerMovieBookingDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public CustomerMovieBookingDTO(Movie movie)
        {
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
        }
    }


}
