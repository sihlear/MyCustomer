using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPS.Models
{
    public class Customer : PageModel
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Must be at least 5 characters long.")]
        [Display(Name="Please Enter your name and surname")]
        public string CustomerName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Please enter a Valid Email address")]
        public string Email { get; set; }
        [Phone]
        [RegularExpression(@"^(\+\d{1, 2}\s)?\(?\d{3}\)?[\s.-]?\d{ 3}[\s.-]?\d{ 4}$”)")]
        public string Phone { get; set; }

    }
}
