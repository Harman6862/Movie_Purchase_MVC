using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Purchase_MVC.Models
{
    public class MovieRent
    {
        [Key]
        public int Id { get; set; } // Rent Id as primary Key

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer_Obj { get; set; }

        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public Movie Movie_Obj { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }


    }
}
