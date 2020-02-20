using System.ComponentModel.DataAnnotations;

namespace Movie_Purchase_MVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; } // Moive Id as primary Key
        [Required]
        public string MovieTitle { get; set; } //Movie Title as a required field which hold movie name
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        [Required]
        public decimal RentPerDay { get; set; } //Movie Rent Price per day as a required field.
    }
}
