using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int Runtime { get; set; }
        public MovieDTO(Movies movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Description = movie.Description;
            Rating = movie.Rating;
            Runtime = movie.RuntimeMins;
        }
    }
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNr { get; set; }
        public int Capacity { get; set; }
        public int MovieId { get; set; }
        public DateTime StartsAt { get; set; }
        public ScreeningDTO(Screenings screening)
        {
            Id = screening.Id;
            ScreenNr = screening.ScreenNr;
            Capacity = screening.Capacity;
            MovieId = screening.MoviesId;
            StartsAt = screening.StartsAt;
        }
    }
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public int ScreeningId { get; set; }
        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            PhoneNr = customer.PhoneNr;
            ScreeningId = customer.ScreeningId;
        }
    }
    public class GetScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNr { get; set; }
        public int Capacity { get; set; }
        public int MovieId { get; set; }
        public MovieDTO Movies { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public GetScreeningDTO(Screenings screening)
        {
            Id = screening.Id;
            ScreenNr = screening.ScreenNr;
            Capacity = screening.Capacity;
            MovieId = screening.MoviesId;
            Movies = new MovieDTO(screening.Movies);
            StartsAt = screening.StartsAt;
            Created = screening.CreatedAt;
            Updated = screening.UpdatedAt;
        }
        public static List<GetScreeningDTO> FromRepository(IEnumerable<Screenings> screenings)
        {
            var results = new List<GetScreeningDTO>();
            foreach (var screening in screenings)
            {
                results.Add(new GetScreeningDTO(screening));
            }
            return results;
        }
    }
    public class GetMovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int Runtime { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public GetMovieDTO(Movies movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Description = movie.Description;
            Rating = movie.Rating;
            Runtime = movie.RuntimeMins;
            Created = movie.CreatedAt;
            Updated = movie.UpdatedAt;
        }
        public static List<GetMovieDTO> FromRepository(IEnumerable<Movies> movies)
        {
            var results = new List<GetMovieDTO>();
            foreach (var movie in movies)
            {
                results.Add(new GetMovieDTO(movie));
            }
            return results;
        }
    }
    public class GetCustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public int ScreeningId { get; set; }
        public ScreeningDTO Screening { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public GetCustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            PhoneNr = customer.PhoneNr;
            ScreeningId = customer.ScreeningId;
            Screening = new ScreeningDTO(customer.Screening);
            Created = customer.CreatedAt;
            Updated = customer.UpdatedAt;
        }
        public static List<GetCustomerDTO> FromRepository(IEnumerable<Customer> customers)
        {
            var results = new List<GetCustomerDTO>();
            foreach (var customer in customers)
            {
                results.Add(new GetCustomerDTO(customer));
            }
            return results;
        }
    }
}
