using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieRentalApp.Models
{
    public partial class User
    {
        public User()
        {
            Rentals = new HashSet<Rental>();
        }

        [Key]
        public int UID { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        public int? RentedMovies { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;

        [InverseProperty("User")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
