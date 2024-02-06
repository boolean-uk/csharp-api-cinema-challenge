﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.PureModels
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("ticket_id")]
        public int TicketId { get; set; }

        [Column("customer_id")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        [Column("screening_id")]
        [ForeignKey("ScreeningId")]
        public int ScreeningId { get; set; }

        [Column("number_of_seats")]
        public int NumberOfSeats { get; set; }
    }
}