namespace api_cinema_challenge.DTOs
{
    public class DTOCustomerObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public DTOCustomerObject (int id, string name, string email, string phone, DateTime createdAt, DateTime uppdatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Created = createdAt;
            this.Updated = uppdatedAt;
        }
    }
}
