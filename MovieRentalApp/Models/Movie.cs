using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentalApp.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Rentals = new HashSet<Rental>();
        }

        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Year { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? Genre { get; set; }
        public double Cost { get; set; }
        [StringLength(10)]
        public string? ImagePoster { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Image { get; set; }
        public int? Duration { get; set; }
        public double? Rating { get; set; }

        [InverseProperty("Movie")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
