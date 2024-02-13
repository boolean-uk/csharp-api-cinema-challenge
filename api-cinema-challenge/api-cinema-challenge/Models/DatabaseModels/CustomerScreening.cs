using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DatabaseModels
{
    [PrimaryKey(nameof(CustomerId), nameof(ScreeningId))]
    [Table("customersScreenings")]
    public class CustomerScreening
    {
        [Column("customerid")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Column("screeningid")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
    }
}
