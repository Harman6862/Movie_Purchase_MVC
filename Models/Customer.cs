using System.ComponentModel.DataAnnotations;

namespace Movie_Purchase_MVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } // Customer Id as primary Key
        [Required]
        public string Full_Name { get; set; } // Customer Full Name as a required field 
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }// Customer Email as a required field 


    }
}
