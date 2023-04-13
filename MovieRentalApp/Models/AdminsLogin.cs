using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Models
{
    public class AdminsLogin
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
