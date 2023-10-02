using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPS.Models
{
    public class Customer
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Must be at least 5 characters long.")]
        [Display(Name="Please Enter your name and surname")]
        public string CustomerName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a Valid Email address")]
        public string Email { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }

    }
}
