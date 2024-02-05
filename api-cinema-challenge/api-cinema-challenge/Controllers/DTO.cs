using api_cinema_challenge.Models;

namespace api_cinema_challenge.Controllers
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int Runtime { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public MovieDTO(Movies movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Description = movie.Description;
            Rating = movie.Rating;
            Runtime = movie.RuntimeMins;
            Created = movie.CreatedAt;
            Updated = movie.UpdatedAt;
        }
    }
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNr { get; set; }
        public int Capacity { get; set; }
        //public int MovieId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public ScreeningDTO(Screenings screening)
        {
            Id = screening.Id;
            ScreenNr = screening.ScreenNr;
            Capacity = screening.Capacity;
            //MovieId = screening.MoviesId;
            StartsAt = screening.StartsAt;
            Created = screening.CreatedAt;
            Updated = screening.UpdatedAt;
        }
    }
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            PhoneNr = customer.PhoneNr;
            Created = customer.CreatedAt;
            Updated = customer.UpdatedAt;
        }
    }
    public class GetScreeningDTO
    {
        public string Status { get; set; }
        public ScreeningDTO Data { get; set; }
        public GetScreeningDTO(ScreeningDTO screening)
        {
            Status = "Success";
            Data = screening;
        }
        public static List<GetScreeningDTO> FromRepository(IEnumerable<Screenings> screenings)
        {
            var results = new List<GetScreeningDTO>();
            foreach (var screening in screenings)
            {
                ScreeningDTO screeningDTO = new ScreeningDTO(screening);
                results.Add(new GetScreeningDTO(screeningDTO));
            }
            return results;
        }
    }
    public class GetMovieDTO
    {
        public string Status { get; set; }
        public MovieDTO Data { get; set; }
        public GetMovieDTO(MovieDTO movie)
        {
            Status = "Success";
            Data = movie;
        }
        public static List<GetMovieDTO> FromRepository(IEnumerable<Movies> movies)
        {
            var results = new List<GetMovieDTO>();
            foreach (var movie in movies)
            {
                MovieDTO movieDTO = new MovieDTO(movie);
                results.Add(new GetMovieDTO(movieDTO));
            }
            return results;
        }
    }
    public class GetCustomerDTO
    {
        public string Status { get; set; }
        public CustomerDTO Data { get; set; }
        public GetCustomerDTO(CustomerDTO customer)
        {
            Status = "Success";
            Data = customer;
        }
        public static List<GetCustomerDTO> FromRepository(IEnumerable<Customer> customers)
        {
            var results = new List<GetCustomerDTO>();
            foreach (var customer in customers)
            {
                CustomerDTO customerDTO = new CustomerDTO(customer);
                results.Add(new GetCustomerDTO(customerDTO));
            }
            return results;
        }
    }
}
