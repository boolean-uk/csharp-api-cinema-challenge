using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{

    /**
    class MovieResponseDTO
    {
        // define all of the properties that we want to return to the client
        public int Id { get; set; }
        public string FullName { get; set; }

        public List<PatientAssignmentDTO> Appointments { get; set; } = new List<PatientAssignmentDTO>();

        public PatientResponseDTO(Patient patient)
        {
            Id = patient.Id;
            FullName = patient.FullName;

            foreach (Appointment appo in patient.Appointments)
            {
              Appointments.Add(new PatientAssignmentDTO(appo));
           }
        }
    }

    class MovieScreeningDTO
    {
        public DateTime Booking { get; set; }

        public DoctorDTO Doctor { get; set; }

        public PatientAssignmentDTO(Appointment appo)
        {
            Booking = appo.Booking;
            Doctor = new ScreeningDTO(appo.Screening);
        }
    }

    **/


    // SINGLES

    class MovieDTO {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RuntimeMins { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public MovieDTO(Movie m)
        {
            Id = m.Id;
            Title = m.Title;
            Rating = m.Rating;
            Description = m.Description;
            RuntimeMins = m.RuntimeMins;
            CreatedAt = m.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            UpdatedAt = m.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }

    }

    class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public string StartsAt { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public ScreeningDTO(Screening s)
        {
            Id = s.Id;
            ScreenNumber = s.ScreenNumber;
            Capacity = s.Capacity;
            StartsAt = s.StartsAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            CreatedAt = s.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            UpdatedAt = s.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }
    }


    class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email {get; set; }

        public string Phone {get; set; }

        public string CreatedAt {get ; set; }

        public string UpdatedAt {get; set; }

        public CustomerDTO(Customer c)
        {
            Id = c.Id;
            Name = c.Name;
            Email = c.Email;
            Phone = c.Phone;                                                                        
            CreatedAt = c.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");  
            UpdatedAt = c.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }
    }
}
