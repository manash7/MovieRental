using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieRentalApp.Models
{
    [Table("Rental")]
    public partial class Rental
    {
        [Key]
        public int RID { get; set; }
        public int UserID { get; set; }
        public int MovieID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Start { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime End { get; set; }

        [ForeignKey("MovieID")]
        [InverseProperty("Rentals")]
        public virtual Movie Movie { get; set; } = null!;
        [ForeignKey("UserID")]
        [InverseProperty("Rentals")]
        public virtual User User { get; set; } = null!;
    }
}
