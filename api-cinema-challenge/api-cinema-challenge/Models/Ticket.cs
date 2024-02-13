using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using api_cinema_challenge.Models.Base;
using api_cinema_challenge.User_Requests;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    public class Ticket : ModelBase
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required, Column("num_seats")]
        public int NumSeats {  get; set; }

        [ForeignKey(nameof(Customer)), Column("fk_id_customer")]
        public int FK_Id_Customer {  get; set; }
        [ForeignKey(nameof(Screening)), Column("fk_id_screening")]
        public int FK_Id_Screening {  get; set; }

        public Customer Customer;
        public Screening Screening;


        public Ticket() { }
        public Ticket(TicketRequest request)
        {
            if (request == default(TicketRequest)) return;

            NumSeats = request.NumSeats;
            FK_Id_Customer = request.FK_Id_Customer;
            FK_Id_Screening = request.FK_Id_Screening;
        }
    }
}
