using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPS.Models
{
    public class PaymentCard
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        int Id;
        [Required(ErrorMessage ="Please enter a valid card number")]
        int CardNumber;
        [Required(ErrorMessage = "Please enter a valid CVC number")]
        int Cvc;
        [Required(ErrorMessage = "Please enter a Month and year")]
        string CardExpiryDate;
        [Required]
        [StringLength(40, MinimumLength = 10, ErrorMessage = "Please Enter valid Address")]
        string BillingAddress ;
    }
}
