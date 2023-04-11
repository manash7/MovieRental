using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieRentalApp.Models
{
    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int AID { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
    }
}
